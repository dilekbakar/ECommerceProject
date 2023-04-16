using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Infrastructure.Contexts;

namespace ECommerceService.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
