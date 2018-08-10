
 
using System.Security.Claims;
using System.Threading.Tasks;
using BPNew.Service.Auth;
using BPNew.Service.Helpers;
using BPNew.Service.Models;
using BPNew.Service.Models.Entities;
using BPNew.Service.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        private readonly ILogger _logger;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, 
                                IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions, ILogger<AuthController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtFactory = jwtFactory;
            _jwtOptions = jwtOptions.Value;
            _logger = logger;
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

        // POST api/auth/findbyname
        [HttpPost("findbyname")]
        public async Task<AppUser> FindByNameAysnc([FromBody]string name)
        {
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
    }
}
