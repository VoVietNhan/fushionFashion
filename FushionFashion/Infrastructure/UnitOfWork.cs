using Application;
using Application.Repository;
using Infrastructure.Repository;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _appDBContext;
        private readonly IAccountRepository _accountRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public UnitOfWork(AppDBContext appDBContext, 
            IAccountRepository accountRepository, 
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _appDBContext = appDBContext;
            _productRepository = productRepository; 
            _accountRepository = accountRepository;
            _categoryRepository = categoryRepository;
        }

        public IAccountRepository AccountRepository => _accountRepository;
        public IProductRepository ProductRepository => _productRepository;
        public ICategoryRepository CategoryRepository => _categoryRepository;

        public async Task<int> SaveChangeAsync() => await _appDBContext.SaveChangesAsync();
    }
}
