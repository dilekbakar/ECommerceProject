using AutoMapper;
using Common.Library.Infrastructure.Extensions;
using Common.Library.Models.Page;
using ECommerceService.Application.Interfaces;
using ECommerceService.Application.ViewModels.Products;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedViewModel<GetProductsVM>>
    {
        #region DI
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        #endregion

        public async Task<PagedViewModel<GetProductsVM>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var query = await _productRepository.GetAll();
            var dto = _mapper.Map<List<GetProductsVM>>(query);

            return dto.AsQueryable().GetPaged(request.Page, request.PageSize);
        }
    }
}
