using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceService.Application.ViewModels.Discounts
{
    public class GetDiscountVM
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CategoryId { get; set; }
        public float DiscountAmount { get; set; }
       
    }
}
