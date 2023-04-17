using AutoMapper;
using ECommerceService.Application.ViewModels.Categories;
using ECommerceService.Application.ViewModels.Discounts;
using ECommerceService.Application.ViewModels.Products;
using ECommerceService.Domain.Entities.Models;

namespace ECommerceService.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetProductsVM>().ReverseMap();
            CreateMap<Category, GetCategoryVM>().ReverseMap();
            CreateMap<Discount, GetDiscountVM>().ReverseMap();
           
        }
    }
}
