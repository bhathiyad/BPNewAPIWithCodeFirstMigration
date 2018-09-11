using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Models;
using BPNewBO.UserMgt;
using Microsoft.EntityFrameworkCore;

namespace BPNew.Service.Services.UserMgtRepository
{
    public class UserMgtRepository : IUserMgtRepository
    {
        private AppDbMigrationContext _appDBContext;
        public UserMgtRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }

        public async Task<List<UserReadModel>> GetBoardSecrataries(int subCategoryId)
        {

            var boardSecrataryList = await (from u in _appDBContext.Users
                                            where u.Status == 1
                                            join a in _appDBContext.Accesses on u.CustomUserId equals a.CustomUserId
                                            where Guid.Parse("2982bf3b-121b-4b90-aea0-49b9b5996356") == a.RoleId
                                                    && a.Type == 1 && a.RefId == subCategoryId
                                            select new UserReadModel
                                            {
                                                CustomUserId = u.CustomUserId,
                                                UserName = u.FirstName + " " + u.LastName,
                                            }).ToListAsync();

            return boardSecrataryList;
        }
    }
}
