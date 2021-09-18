using System;

namespace Delivery_Service.API.ViewModel
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProviderId { get; set; }
    }
}
