using AutoMapper;
using Common.Library.Infrastructure.Extensions;
using Common.Library.Models.Page;
using ECommerceService.Application.Interfaces;
using ECommerceService.Application.ViewModels.Categories;
using MediatR;

namespace ECommerceService.Application.Features.Queries.GetCategories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, PagedViewModel<GetCategoryVM>>
    {
        #region DI
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        #endregion

        public async Task<PagedViewModel<GetCategoryVM>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var query = await _categoryRepository.GetAll();
            var dto = _mapper.Map<List<GetCategoryVM>>(query);
            return dto.AsQueryable().GetPaged(request.Page,request.PageSize);
        }
    }
}
