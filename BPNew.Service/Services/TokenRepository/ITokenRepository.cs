using BPNew.Service.Data.Migrations;
using BPNew.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Models;

namespace BPNew.Service.Services.TokenRepository
{
    public interface ITokenRepository
    {
        Task<bool> AddToken(Models.Token token);
        Task<Models.Token> GetToken(TokenRequestViewModel tokenModel);
        Task<bool> RemoveToken(Models.Token token);
    }
}
