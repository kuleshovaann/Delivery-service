using System;

namespace DeliveryService.Models
{
    public class Dish
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Composition { get; set; }

        public double Weight { get; set; }

        public int Calories { get; set; }
    }
}
