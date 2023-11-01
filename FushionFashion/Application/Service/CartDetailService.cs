using Application.Interface;
using Application.ViewModel.CartViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class CartDetailService : ICartDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IClaimService _claimService;

        public CartDetailService(IUnitOfWork unitOfWork, IMapper mapper, IClaimService claimService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _claimService = claimService;
        }

        public Task CreateCartDetail(CreateCartDetailViewModel cartDetail)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartDetailViewModel>> GetCartDetail(Guid cartId)
        {
            throw new NotImplementedException();
        }
    }
}
