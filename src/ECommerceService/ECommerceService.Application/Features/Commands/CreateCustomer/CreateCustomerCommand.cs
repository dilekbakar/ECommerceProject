using ECommerceService.Application.ViewModels.Customers;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<bool>
    {
        public CreateCustomerVM CreateCustomerVM { get; set; }
    }
}
