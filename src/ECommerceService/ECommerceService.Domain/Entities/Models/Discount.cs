using ECommerceService.Domain.Entities.Base;

namespace ECommerceService.Domain.Entities.Models
{
    public class Discount : BaseEntity
    {
        /// <summary>
        /// Black Friday indirimi vs.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Black Friday özel %10 indirim! vs.
        /// </summary>
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CategoryId { get; set; }
        /// <summary>
        /// %kaç indirim olacağı float şeklinde belirlenecek. Örn: %10 indirim uygulanacak : 0.1 şeklinde girilecek 
        /// </summary>
        public float DiscountAmount { get; set; }
    }
}
