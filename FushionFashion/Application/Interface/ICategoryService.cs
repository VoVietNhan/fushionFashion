using Application.ViewModel.CategoryViewModel;
using Application.ViewModel.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetCategory();
        public Task<CreateCategoryViewModel?> CreateCategory(CreateCategoryViewModel categoryDTO);
        Task DeleteCategory(Guid id);
        public Task<UpdateCategoryViewModel?> UpdateCategory(Guid id, UpdateCategoryViewModel categoryDTO);
        Task<CategoryViewModel> GetCategoryById(Guid id);
    }
}
