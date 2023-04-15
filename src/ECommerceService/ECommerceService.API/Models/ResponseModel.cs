namespace ECommerceService.API.Models
{
    public class ResponseModel
    {
        public object Data { get; set; }
        public bool Success { get; set; } = false;
        public string Message { get; set; }
    }
}
