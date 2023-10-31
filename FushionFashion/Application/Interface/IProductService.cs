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
        Task<List<Product>> GetProduct();
        Task AddProduct(Product product);
        Task DeleteProduct(int id);
        Task UpdateProduct(Product product);
        Task<Product> GetProductById(int id);
    }
}
