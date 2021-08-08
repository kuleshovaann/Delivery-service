using System;
using DeliverySystem.Enums;

namespace DeliverySystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string Address { get; set; }
        public double FullPrice { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Delivery NameDelivery { get; set; }
        public DateTime TimeOfDeliveryDone { get; set; }
        public Status Status { get; set; }
    }
}
