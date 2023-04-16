using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        #region DI
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        #endregion

        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            Customer customer = new() { 
            Name=request.CreateCustomerVM.Name,
            Mail=request.CreateCustomerVM.Mail,
            Phone=request.CreateCustomerVM.Phone,
            IsActive=request.CreateCustomerVM.isActive
            };       
            _=await _customerRepository.AddAsync(customer);
            return true;
        }
    }
}
