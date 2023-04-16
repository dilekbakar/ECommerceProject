using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Infrastructure.Contexts;

namespace ECommerceService.Infrastructure.Repositories
{
    public class BasketRepository : Repository<Basket>, IBasketRepository
    {
        public BasketRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
