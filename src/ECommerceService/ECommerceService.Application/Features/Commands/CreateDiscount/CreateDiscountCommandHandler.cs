using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateDiscount
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, bool>
    {
        #region DI
        private readonly IDiscountRepository _discountRepository;

        public CreateDiscountCommandHandler(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }
        #endregion

        public async Task<bool> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            Discount discount = new()
            {
                Name=request.CreateDiscountVM.Name,
                Description=request.CreateDiscountVM.Description,
                StartDate=request.CreateDiscountVM.StartDate,
                EndDate=request.CreateDiscountVM.EndDate,
                CategoryId=request.CreateDiscountVM.CategoryId,
                DiscountAmount=request.CreateDiscountVM.DiscountAmount,
                IsActive=request.CreateDiscountVM.isActive
            };
            _=await _discountRepository.AddAsync(discount);
            return true;
        }
    }
}
