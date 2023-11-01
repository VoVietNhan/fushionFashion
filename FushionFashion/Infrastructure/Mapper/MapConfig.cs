using Application.ViewModel.AccountViewModel;
using Application.ViewModel.CategoryViewModel;
using Application.ViewModel.ProductViewModel;
using AutoMapper;
using Domain.Entity;

namespace Infrastructure.Mapper
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<AccountViewModel, Account>().ReverseMap();
            CreateMap<ProductViewModel, Product>().ReverseMap();

            CreateMap<CreateProductViewModel, Product>().ReverseMap();
            CreateMap<UpdateProductViewModel, Product>().ReverseMap();

            CreateMap<CreateCategoryViewModel, Category>().ReverseMap();
        }
    }
}
