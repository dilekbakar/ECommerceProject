using ECommerceService.Application.Interfaces;
using MediatR;

namespace ECommerceService.Application.Features.Commands.UpdateProductPrice
{
    public class UpdateProductPriceCommandHandler : IRequestHandler<UpdateProductPriceCommand, bool>
    {
        #region DI
        private readonly IDiscountRepository _discountRepository;
        private readonly IProductRepository _productRepository;

        public UpdateProductPriceCommandHandler(IDiscountRepository discountRepository, IProductRepository productRepository)
        {
            _discountRepository = discountRepository;
            _productRepository = productRepository;
        }
        #endregion
        public async Task<bool> Handle(UpdateProductPriceCommand request, CancellationToken cancellationToken)
        {
            var discounts =await _discountRepository.GetAll();
            foreach (var discount in discounts)
            {
                var products = await _productRepository.GetList(x=>x.CategoryId==discount.CategoryId);
                foreach (var product in products)
                {
                    product.DiscountedPrice= product.Price - (discount.DiscountAmount*product.Price);
                    await _productRepository.UpdateAsync(product);
                }
            }
            return true;
        }
    }
}
