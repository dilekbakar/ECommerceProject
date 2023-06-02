using Common.Library.Models.Page;
using ECommerceService.Application.ViewModels.Discounts;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetActiveDiscounts
{
    public class GetActiveDiscountsQuery : BasePagedQuery, IRequest<PagedViewModel<GetDiscountVM>>
    {
        public GetActiveDiscountsQuery(int page, int pageSize) : base(page, pageSize)
        {
        }
    }
}
