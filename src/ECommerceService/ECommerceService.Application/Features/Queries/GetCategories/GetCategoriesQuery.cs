using Common.Library.Models.Page;
using ECommerceService.Application.ViewModels.Categories;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetCategories
{
    public class GetCategoriesQuery : BasePagedQuery, IRequest<PagedViewModel<GetCategoryVM>>
    {
        public GetCategoriesQuery(int page, int pageSize) : base(page, pageSize)
        {
        }
    }
}
