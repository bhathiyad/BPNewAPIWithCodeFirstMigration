
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using BPNew.Service.Auth;
using BPNew.Service.Helpers;
using BPNew.Service.Models;
using BPNew.Service.Models.Entities;
using BPNew.Service.Services.TokenRepository;
using BPNew.Service.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace BPNew.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtFactory _jwtFactory;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly ILogger<AuthController> _logger;
        private readonly ITokenRepository _tokenRepository;
        public IConfiguration Configuration { get; }

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
                                IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions, ILogger<AuthController> logger,
                                ITokenRepository tokenRepository, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
            _logger = logger;
            _tokenRepository = tokenRepository;
            Configuration = configuration;
        }

        [HttpPost("Auth")]
        public async Task<IActionResult> Auth([FromBody]TokenRequestViewModel model)
        {
            // return a generic HTTP Status 500 (Server Error)
            // if the client payload is invalid.
            if (model == null) return new StatusCodeResult(500);

            switch (model.grant_type)
            {
                case "password":
                    return await GetToken(model);
                case "refresh_token":
                    return await RefreshToken(model);
                default:
                    // not supported - return a HTTP 401 (Unauthorized)
                    return new UnauthorizedResult();
            }
        }

        // POST api/auth/login
        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody]CredentialsViewModel credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var identity = await GetClaimsIdentity(credentials.UserName, credentials.Password);
            if (identity == null)
            {
                return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));
            }

            var jwt = await Tokens.GenerateJwt(identity, _jwtFactory, credentials.UserName, _jwtOptions, new JsonSerializerSettings { Formatting = Formatting.Indented });
            //return new OkObjectResult(jwt);
            return new JsonResult(jwt);
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            // get the user to verifty
            var userToVerify = await _userManager.FindByNameAsync(userName);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            // check the credentials
            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id));
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                return await Task.FromResult<ClaimsIdentity>(null);

            // get the user to verifty
            var userToVerify = await _userManager.FindByNameAsync(userName);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            // check the credentials
            //if (await _userManager.CheckPasswordAsync(userToVerify, password))
            //{
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id));
            //}

            // Credentials are invalid, or account doesn't exist
            //return await Task.FromResult<ClaimsIdentity>(null);
        }

        // POST api/auth/findbyname
        [HttpPost("findbyname")]
        public async Task<AppUser> FindByNameAysnc([FromBody]string name)
        {
            _logger.LogInformation("***********************************************************************************************");
            _logger.LogInformation($"Name {name}");

            var user = await _userManager.FindByNameAsync(name);

            return user;
        }

        // POST api/auth/findbyid
        [HttpPost("findbyid")]
        public async Task<AppUser> FindByIdAysnc([FromBody]string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            return user;
        }

        // POST api/auth/CreateAsync
        [HttpPost("CreateAsync")]
        public async Task<IActionResult> CreateAsync([FromBody]JObject UserModel)
        {
            IdentityResult res = null;
            try
            {
                AppUser user = UserModel["user"].ToObject<AppUser>();
                string password = UserModel["Password"].ToObject<string>();
                res = await _userManager.CreateAsync(user, password);
            }
            catch (System.Exception ex)
            {

                throw;
            }

            return new OkObjectResult(res.Succeeded ? true : false);
        }

        private async Task<IActionResult> GetToken(TokenRequestViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var identity = await GetClaimsIdentity(model.username, model.password);
                if (identity == null)
                {
                    return BadRequest(Errors.AddErrorToModelState("login_failure", "Invalid username or password.", ModelState));
                }

                // check if there's an user with the given username
                var user = await _userManager.FindByNameAsync(model.username);
                // fallback to support e-mail address instead of username
                if (user == null && model.username.Contains("@"))
                    user = await _userManager.FindByEmailAsync(model.username);

                if (user == null
                    || !await _userManager.CheckPasswordAsync(user, model.password))
                {
                    // user does not exists or password mismatch
                    return new UnauthorizedResult();
                }

                // username & password matches: create the refresh token
                var rt = CreateRefreshToken(model.client_id, user.Id);

                // add the new refresh token to the DB
                //DbContext.Tokens.Add(rt);
                //DbContext.SaveChanges();
                await _tokenRepository.AddToken(rt);

                // create & return the access token
                var t = await CreateAccessToken(model, rt.Value);
                //return Json(t);

                //return await Task.FromResult(Ok());
                return new JsonResult(t);
            }
            catch (Exception ex)
            {
                return new UnauthorizedResult();
            }
        }

        private async Task<IActionResult> RefreshToken(TokenRequestViewModel model)
        {
            try
            {
                // check if the received refreshToken exists for the given clientId
                //var rt = DbContext.Tokens
                //    .FirstOrDefault(t =>
                //    t.ClientId == model.client_id
                //    && t.Value == model.refresh_token);

                var rt = await _tokenRepository.GetToken(model);

                if (rt == null)
                {
                    // refresh token not found or invalid (or invalid clientId)
                    return new UnauthorizedResult();
                }

                // check if there's an user with the refresh token's userId
                var user = await _userManager.FindByIdAsync(rt.UserId);

                if (user == null)
                {
                    // UserId not found or invalid
                    return new UnauthorizedResult();
                }

                // generate a new refresh token
                var rtNew = CreateRefreshToken(rt.ClientId, rt.UserId);

                // invalidate the old refresh token (by deleting it)
                //DbContext.Tokens.Remove(rt);
                await _tokenRepository.RemoveToken(rt);

                // add the new refresh token
                //DbContext.Tokens.Add(rtNew);

                // persist changes in the DB
                //DbContext.SaveChanges();

                await _tokenRepository.AddToken(rtNew); //rt

                // create a new access token...
                var response = await CreateAccessToken(model, rtNew.Value);

                // ... and send it to the client
                return new JsonResult(response);
                //return await Task.FromResult(Ok());
            }
            catch (Exception ex)
            {
                return new UnauthorizedResult();
            }
        }

        private async Task<TokenResponseViewModel> CreateAccessToken(TokenRequestViewModel model, string refreshToken)
        {
            DateTime now = DateTime.UtcNow;
            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            // add the registered claims for JWT (RFC7519).
            // For more info, see https://tools.ietf.org/html/rfc7519#section-4.1
            //var claims = new[] {
            //    new Claim(JwtRegisteredClaimNames.Sub, userId),
            //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //    new Claim(JwtRegisteredClaimNames.Iat,
            //        new DateTimeOffset(now).ToUnixTimeSeconds().ToString())
            //    // TODO: add additional claims here
            //};

            //var tokenExpirationMins =
            //    Configuration.GetValue<int>("Auth:Jwt:TokenExpirationInMinutes");
            //var issuerSigningKey = new SymmetricSecurityKey(
            //    Encoding.UTF8.GetBytes(Configuration["Auth:Jwt:Key"]));

            //var token = new JwtSecurityToken(
            //    issuer: Configuration["Auth:Jwt:Issuer"],
            //    audience: Configuration["Auth:Jwt:Audience"],
            //    claims: claims,
            //    notBefore: now,
            //    expires: now.Add(TimeSpan.FromMinutes(tokenExpirationMins)),
            //    signingCredentials: new SigningCredentials(
            //        issuerSigningKey, SecurityAlgorithms.HmacSha256)
            //);
            //var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);

            ClaimsIdentity claimsIdentity = null;

            if (model.username == null)
            {
                var appUser = await FindByIdAysnc(model.client_id);
                model.username = appUser.UserName;

                claimsIdentity = await GetClaimsIdentity(model.username);
            }
            else
            {
                claimsIdentity = await GetClaimsIdentity(model.username, model.password);
            }

            var jwt = await Tokens.GenerateJwt(claimsIdentity, _jwtFactory, model.username, _jwtOptions,
                                                        new JsonSerializerSettings { Formatting = Formatting.Indented });

            return new TokenResponseViewModel()
            {
                Token = jwt,
                Expiration = (int)(new JwtIssuerOptions().ValidFor.TotalMinutes),
                RefreshToken = refreshToken
            };
        }
        private Token CreateRefreshToken(string clientId, string userId)
        {
            return new Token()
            {
                ClientId = clientId,
                UserId = userId,
                Type = 0,
                Value = Guid.NewGuid().ToString("N"),
                CreatedDate = DateTime.UtcNow
            };
        }
    }
}
