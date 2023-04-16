namespace ECommerceService.Application.ViewModels.Discounts
{
    public class CreateDiscountVM
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CategoryId { get; set; }
        public float DiscountAmount { get; set; }
        public bool isActive { get; set; }
    }
}
