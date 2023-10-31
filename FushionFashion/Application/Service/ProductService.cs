using Application.Interface;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddProduct(Product product)
        {
            await _unitOfWork.ProductRepository.AddAsync(product);
            var a = await _unitOfWork.SaveChangeAsync();
            if (a > 0)
            {
                Console.WriteLine("Add product sussecfully");
            }
            else
            {
                Console.WriteLine("Add product fail");
            }
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
