using Application.Interface;
using Application.ViewModel.AccountViewModel;
using Application.ViewModel.ProductViewModel;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }


        public async Task<CreateProductViewModel?> CreateProduct(CreateProductViewModel productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            await _unitOfWork.ProductRepository.AddAsync(product);
            var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;
            if (isSuccess)
            {
                return _mapper.Map<CreateProductViewModel>(product);
            }
            return null;
        }

        public Task DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetProduct()
        {
            var product = await _unitOfWork.ProductRepository.GetAllAsync();
            return _mapper.Map<List<ProductViewModel>>(product);
        }

        public async Task<ProductViewModel> GetProductById(Guid id)
        {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(id);  
            return _mapper.Map<ProductViewModel>(product);  
        }

        public async Task<UpdateProductViewModel?> UpdateProduct(Guid id, UpdateProductViewModel productDTO)
        {

            var product = await _unitOfWork.ProductRepository.GetByIdAsync(id);

            if (product == null)
            {
                return null;
            }
            _mapper.Map(productDTO, product);

            _unitOfWork.ProductRepository.Update(product);
            var isSuccess = await _unitOfWork.SaveChangeAsync() > 0;

            if (isSuccess)
            {
                return _mapper.Map<UpdateProductViewModel>(product);
            }

            return null;
        }

        
    }
}
