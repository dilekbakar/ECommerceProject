using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        #region DI
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new()
            {
                Name=request.CreateProductVM.Name,
                Stock=request.CreateProductVM.Stock,
                Price=request.CreateProductVM.Price,
                ImageUrl=request.CreateProductVM.ImageUrl,
                CategoryId=request.CreateProductVM.CategoryId,
                IsActive=request.CreateProductVM.isActive
            };
            _=await _productRepository.AddAsync(product);
            return true;
        }
    }
}
