using Application.Interface;
using Application.ViewModel.AccountViewModel;
using AutoMapper;

namespace Application.Service
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;

        public AccountService(IUnitOfWork  unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }
        public async Task<AccountViewModel> GetAccountById(Guid AccountId)
        {
            var account = await _unitOfWork.AccountRepository.GetByIdAsync(AccountId);
            return _mapper.Map<AccountViewModel>(account);
        }

        public async Task<List<AccountViewModel>> GetAllAccounts()
        {
            var accounts = await _unitOfWork.AccountRepository.GetAllAsync();
            return _mapper.Map<List<AccountViewModel>>(accounts);
        }
    }
}
