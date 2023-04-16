using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Infrastructure.Contexts;

namespace ECommerceService.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
