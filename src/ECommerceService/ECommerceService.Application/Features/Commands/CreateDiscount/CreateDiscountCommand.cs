using ECommerceService.Application.ViewModels.Discounts;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateDiscount
{
    public class CreateDiscountCommand : IRequest<bool>
    {
        public CreateDiscountVM CreateDiscountVM { get; set; }
    }
}
