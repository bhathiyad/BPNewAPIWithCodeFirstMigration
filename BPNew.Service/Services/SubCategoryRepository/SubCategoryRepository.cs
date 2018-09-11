using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Models;
using BPNewBO.SubCategory;
using Microsoft.EntityFrameworkCore;

namespace BPNew.Service.Services.SubCategoryRepository
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private AppDbMigrationContext _appDBContext;
        public SubCategoryRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }
        public async Task<List<SubCategoryModel>> GetSubCategories()
        {
            var subCategoryList = await _appDBContext.SubCategories.Where(s => s.Status == 1)
                                    .Select(s => new SubCategoryModel()
                                    {
                                        Name = s.Name,
                                        SubCategoryId = s.SubCategoryId
                                    }).ToListAsync();

            return subCategoryList;
        }
    }
}
