using BPNewBO.UserMgt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.Services.UserMgtRepository
{
    public interface IUserMgtRepository
    {
        Task<List<UserReadModel>> GetBoardSecrataries(int subCategoryId);
    }
}
