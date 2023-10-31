using Application.ViewModel.AccountViewModel;
using AutoMapper;
using Domain.Entity;

namespace Infrastructure.Mapper
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<AccountViewModel, Account>().ReverseMap();
        }
    }
}
