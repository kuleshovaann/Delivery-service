using System;
using System.Collections.Generic;
using DeliverySystem.DAL.Enums;

namespace DeliverySystem.DAL.Models
{
    public class Order : BaseModel
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public string Address { get; set; }
        public double FullPrice { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Delivery NameDelivery { get; set; }
        public DateTime TimeOfDeliveryDone { get; set; }
        public Status Status { get; set; }
    }
}
