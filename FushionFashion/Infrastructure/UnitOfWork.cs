using Application;
using Application.Repository;
using Infrastructure.Repository;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _appDBContext;
        private readonly IProductRepository productRepository;

        public UnitOfWork(AppDBContext appDBContext, IProductRepository productRepository)
        {
            _appDBContext = appDBContext;
            this.productRepository = productRepository; 
        }
        public IProductRepository ProductRepository => productRepository;
        public async Task<int> SaveChangeAsync() => await _appDBContext.SaveChangesAsync();
    }
}
