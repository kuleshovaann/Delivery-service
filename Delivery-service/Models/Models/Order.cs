using System.Collections.Generic;

namespace DeliveryService.Models
{
    public class Order
    {
        public Order()
        {
            Dishes = new List<Dish>();
        }
        public Customer Customer { get; set; }

        public Company Company { get; set; }

        public double FullPrice { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
