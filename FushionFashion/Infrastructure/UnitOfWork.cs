using Application;
using Application.Repository;
using Infrastructure.Repository;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _appDBContext;
        private readonly IAccountRepository _accountRepository;

        public UnitOfWork(AppDBContext appDBContext, 
            IAccountRepository accountRepository)
        {
            _appDBContext = appDBContext;
            _accountRepository = accountRepository;
        }

        public IAccountRepository AccountRepository => _accountRepository;

        public async Task<int> SaveChangeAsync() => await _appDBContext.SaveChangesAsync();
    }
}
