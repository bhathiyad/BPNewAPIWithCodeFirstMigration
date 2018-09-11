using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPNew.Service.Models;
using BPNewBO.Category;
using Microsoft.EntityFrameworkCore;

namespace BPNew.Service.Services.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbMigrationContext _appDBContext;
        public CategoryRepository(AppDbMigrationContext applicationDbContext)
        {
            _appDBContext = applicationDbContext;
        }
        public async Task<List<CategoryModel>> GetCategories()
        {
            var categories = await _appDBContext.Categories.Where(c => c.Status == 1)
                                .Select(c => new CategoryModel()
                                {
                                    CategoryId = c.CategoryId,
                                    Name = c.Name
                                }).ToListAsync();

            return categories;
        }
    }
}
