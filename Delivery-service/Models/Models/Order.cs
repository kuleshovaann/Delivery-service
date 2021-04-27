using System;
using System.Collections.Generic;

namespace Models.Models
{
    public class Order
    {
        public Order()
        {
            Titles = new List<Dish>();
        }
        public Customer _customer { get; set; }

        public double FullPrice { get; set; }

        public List<Dish> Titles;
    }
}
