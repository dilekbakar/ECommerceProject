using AutoMapper;
using Common.Library.Infrastructure.Extensions;
using Common.Library.Models.Page;
using ECommerceService.Application.Interfaces;
using ECommerceService.Application.ViewModels.Discounts;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetDiscounts
{
    public class GetDiscountsQueryHandler : IRequestHandler<GetDiscountsQuery, PagedViewModel<GetDiscountVM>>
    {
        #region DI
        private readonly IDiscountRepository _discountRepository;
        private readonly IMapper _mapper;

        public GetDiscountsQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }
        #endregion
        public async Task<PagedViewModel<GetDiscountVM>> Handle(GetDiscountsQuery request, CancellationToken cancellationToken)
        {
            var query= await _discountRepository.GetAll();
            var dto = _mapper.Map<List<GetDiscountVM>>(query);
            return dto.AsQueryable().GetPaged(request.Page,request.PageSize);
        }
    }
}
