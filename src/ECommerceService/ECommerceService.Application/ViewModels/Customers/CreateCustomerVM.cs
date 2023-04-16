namespace ECommerceService.Application.ViewModels.Customers
{
    public class CreateCustomerVM
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public bool isActive { get; set; }
    }
}
