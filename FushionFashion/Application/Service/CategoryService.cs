using Application.Interface;
using Application.ViewModel.CategoryViewModel;
using Application.ViewModel.ProductViewModel;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public async Task<CreateCategoryViewModel?> CreateCategory(CreateCategoryViewModel categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            await _unitOfWork.CategoryRepository.AddAsync(category);
            var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;
            if (isSuccess)
            {
                return _mapper.Map<CreateCategoryViewModel>(category);
            }
            return null;
        }

        public Task DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetCategory()
        {
            throw new NotImplementedException();
        }

        public Task<ProductViewModel> GetCAtegoryById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateProductViewModel?> UpdateCategory(Guid id, UpdateProductViewModel productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
