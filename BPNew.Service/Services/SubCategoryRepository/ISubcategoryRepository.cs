using BPNewBO.SubCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPNew.Service.Services.SubCategoryRepository
{
    public interface ISubCategoryRepository
    {
        Task<List<SubCategoryModel>> GetSubCategories();
    }
}
