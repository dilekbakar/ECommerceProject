using AutoMapper;
using Common.Library.Infrastructure.Extensions;
using Common.Library.Models.Page;
using ECommerceService.Application.Interfaces;
using ECommerceService.Application.ViewModels.Categories;
using ECommerceService.Application.ViewModels.Discounts;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetActiveDiscounts
{
    public class GetActiveDiscountsQueryHandler : IRequestHandler<GetActiveDiscountsQuery, PagedViewModel<GetDiscountVM>>
    {
        #region DI
        private readonly IMapper _mapper;
        private readonly IDiscountRepository _discountRepository;

        public GetActiveDiscountsQueryHandler(IMapper mapper, IDiscountRepository discountRepository)
        {
            _mapper = mapper;
            _discountRepository = discountRepository;
        }
        #endregion
        public async Task<PagedViewModel<GetDiscountVM>> Handle(GetActiveDiscountsQuery request, CancellationToken cancellationToken)
        {
            var currentDate = DateTime.Now;
            var query =await _discountRepository.GetList(x => x.StartDate <= currentDate && x.EndDate >= currentDate);
            var dto = _mapper.Map<List<GetDiscountVM>>(query);
            return dto.AsQueryable().GetPaged(request.Page, request.PageSize);
        }
    }
}
