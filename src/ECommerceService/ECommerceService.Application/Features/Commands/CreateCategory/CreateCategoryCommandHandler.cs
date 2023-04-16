using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using MediatR;

namespace ECommerceService.Application.Features.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        #region DI
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new() { 
            Name=request.CreateCategoryVM.Name,
            IsActive=request.CreateCategoryVM.isActive
            };
            _=await _categoryRepository.AddAsync(category);
            return true;
        }
    }
}
