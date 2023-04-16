﻿namespace ECommerceService.Application.ViewModels.Products
{
    public class CreateProductVM
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }
        public long CategoryId { get; set; }
        public bool isActive { get; set; }
    }
}
