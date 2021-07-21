using System;

namespace DeliverySystem.Models
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Address = customer.Address;
            TimeOrder = DateTime.Now;
        }

        public Customer Customer { get; set; }

        public string Address { get; set; }

        public double FullPrice { get; set; }

        public DateTime TimeOrder { get; set; }

        public Delivery NameDelivery { get; set; }

        public DateTime TimeOfDelivery { get; set; }

        public Status OrderStatus { get; set; }

        public enum Status
        {
            OrderProcessing,
            OrderFulfillment,
            OrderDelivering,
            Delivered
        }
    }
}
