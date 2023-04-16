using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Infrastructure.Contexts;

namespace ECommerceService.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
