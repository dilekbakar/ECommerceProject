using ECommerceService.Application.Interfaces;
using ECommerceService.Domain.Entities.Models;
using ECommerceService.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceService.Infrastructure.Repositories
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        private readonly ECommerceDbContext _context;
        public DiscountRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Discount> GetActiveDiscounts()
        {
            // Aktif Discount'ları getirme işlemleri
            var currentDate = DateTime.Now;
            return _context.Discounts.Where(d => d.StartDate <= currentDate && d.EndDate >= currentDate).ToList();
        }
    }
}
