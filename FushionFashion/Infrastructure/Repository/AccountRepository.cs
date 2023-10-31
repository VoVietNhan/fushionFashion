using Application.Interface;
using Application.Repository;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly AppDBContext _context;

        public AccountRepository(AppDBContext context, ICurrentTime currentTime, IClaimService claimService) : base(context, currentTime, claimService)
        {
            _context = context;
        }

        public async Task<Account?> GetAccountByEmail(string email) => await _context.Accounts.FirstOrDefaultAsync(x => x.Email == email);
    }
}
