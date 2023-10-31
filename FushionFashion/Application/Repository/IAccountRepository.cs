using Domain.Entity;

namespace Application.Repository
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<Account?> GetAccountByEmail(string email);
    }
}
