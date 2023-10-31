using Application.ViewModel.AccountViewModel;

namespace Application.Interface
{
    public interface IAccountService
    {
        Task<List<AccountViewModel>> GetAllAccounts();
        Task<AccountViewModel> GetAccountById(Guid AccountId);
    }
}
