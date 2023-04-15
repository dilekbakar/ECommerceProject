using WebService.Domain.Entities.Base;

namespace ECommerceService.Domain.Entities.Models
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }
    }
}
