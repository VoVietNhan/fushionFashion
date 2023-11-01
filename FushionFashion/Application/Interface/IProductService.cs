using Application.ViewModel.ProductViewModel;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
   public interface IProductService
    {
        Task<List<ProductViewModel>> GetProduct();
        public Task<CreateProductViewModel?> CreateProduct(CreateProductViewModel productDTO);
        Task DeleteProduct(Guid id);
        public Task<UpdateProductViewModel?>UpdateProduct(Guid id, UpdateProductViewModel productDTO);
        Task<ProductViewModel> GetProductById(Guid id);
    }
}
