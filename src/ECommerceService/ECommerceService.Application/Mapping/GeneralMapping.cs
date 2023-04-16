using AutoMapper;
using System.Diagnostics.Contracts;
using System;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Application.ViewModels.Products;

namespace ECommerceService.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetProductsVM>().ReverseMap();
           
        }
    }
}
