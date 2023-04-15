﻿using ECommerceService.Domain.Entities.Base;

namespace ECommerceService.Domain.Entities.Models
{
    public class Order : BaseEntity
    {
        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public long BasketId { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? OrderCode { get; set; }
        public bool isCompleted { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
