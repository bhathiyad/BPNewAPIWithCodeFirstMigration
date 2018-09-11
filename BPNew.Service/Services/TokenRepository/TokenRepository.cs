using BPNew.Service.Models;
using BPNew.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.Services.TokenRepository
{
    public class TokenRepository : ITokenRepository
    {
        private AppDbMigrationContext _appDBContext;
        public TokenRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }
        public async Task<bool> AddToken(Token token)
        {
            try
            {
                //token.Id = null;
                await _appDBContext.Tokens.AddAsync(token);
                await _appDBContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Token> GetToken(TokenRequestViewModel tokenModel)
        {
            try
            {
                var rt = _appDBContext.Tokens
                    .FirstOrDefault(t =>
                    t.UserId == tokenModel.client_id
                    && t.Value == tokenModel.refresh_token);

                return await Task.FromResult(rt);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveToken(Token token)
        {
            try
            {
                var res = _appDBContext.Tokens.Remove(token);
                await _appDBContext.SaveChangesAsync();

                return await Task.FromResult(true);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
    }
}
