using Common.Library.Models.Page;
using ECommerceService.Application.ViewModels.Products;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetProducts
{
    public class GetProductsQuery : BasePagedQuery, IRequest<PagedViewModel<GetProductsVM>>
    {
        public GetProductsQuery(int page, int pageSize) : base(page, pageSize)
        {
        }
    }
}
