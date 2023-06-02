﻿using ECommerceService.Domain.Entities.Models;

namespace ECommerceService.Application.Interfaces
{
    public interface IDiscountRepository : IRepository<Discount>
    {
        IEnumerable<Discount> GetActiveDiscounts();
    }
}
