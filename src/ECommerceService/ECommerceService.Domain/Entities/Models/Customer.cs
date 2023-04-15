using ECommerceService.Domain.Entities.Base;

namespace ECommerceService.Domain.Entities.Models
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
    }
}
