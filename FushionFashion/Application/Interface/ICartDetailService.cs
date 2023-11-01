using Application.ViewModel.CartViewModel;
using Application.ViewModel.CategoryViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICartDetailService
    {
        Task<List<CartDetailViewModel>> GetCartDetail(Guid cartId);
        Task CreateCartDetail(CreateCartDetailViewModel cartDetail);
    }
}
