using Application;
using Application.Repository;
using Infrastructure.Repository;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _appDBContext;
        private readonly IProductRepository productRepository;
        private readonly IAccountRepository _accountRepository;

        public UnitOfWork(AppDBContext appDBContext, 
            IAccountRepository accountRepository, IProductRepository productRepository)
        {
            _appDBContext = appDBContext;
            this.productRepository = productRepository; 
            _accountRepository = accountRepository;
        }
        public IProductRepository ProductRepository => productRepository;

        public IAccountRepository AccountRepository => _accountRepository;

        public async Task<int> SaveChangeAsync() => await _appDBContext.SaveChangesAsync();
    }
}
