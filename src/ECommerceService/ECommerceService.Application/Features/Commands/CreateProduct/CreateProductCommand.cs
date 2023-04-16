using ECommerceService.Application.ViewModels.Products;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<bool>
    {
        public CreateProductVM CreateProductVM { get; set; }
    }
}
