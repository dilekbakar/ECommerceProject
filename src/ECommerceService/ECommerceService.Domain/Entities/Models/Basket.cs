using WebService.Domain.Entities.Base;

namespace ECommerceService.Domain.Entities.Models
{
    public class Basket : BaseEntity
    {
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
