using ECommerceService.Application.ViewModels.Categories;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public CreateCategoryVM CreateCategoryVM { get; set; }
    }
}
