﻿using Application.Interface;
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
            category.Status = Domain.Enum.EnumStatus.Enable;
            await _unitOfWork.CategoryRepository.AddAsync(category);
            var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;
            if (isSuccess)
            {
                return _mapper.Map<CreateCategoryViewModel>(category);
            }
            return null;
        }

        public async Task DeleteCategory(Guid id)
        {
            var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
            category.Status = Domain.Enum.EnumStatus.Disable;
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.SaveChangeAsync();
           
        }

        public async Task<List<CategoryViewModel>> GetCategory()
        {
            var category = await _unitOfWork.CategoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryViewModel>>(category);
        }

        public async Task<CategoryViewModel> GetCategoryById(Guid id)
        {
            var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryViewModel>(category);
        }

        public async Task<UpdateCategoryViewModel?> UpdateCategory(Guid id, UpdateCategoryViewModel categoryDTO)
        {
            var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);

            if (category == null)
            {
                return null;
            }
            _mapper.Map(categoryDTO, category);

            _unitOfWork.CategoryRepository.Update(category);
            var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;

            if (isSuccess)
            {
                return _mapper.Map<UpdateCategoryViewModel>(category);
            }

            return null;
        }
    }
}
