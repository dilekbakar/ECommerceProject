using Common.Library.Models.Page;
using ECommerceService.Application.ViewModels.Discounts;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetDiscounts
{
    public class GetDiscountsQuery : BasePagedQuery, IRequest<PagedViewModel<GetDiscountVM>>
    {
        public GetDiscountsQuery(int page, int pageSize) : base(page, pageSize)
        {
        }
    }
}
