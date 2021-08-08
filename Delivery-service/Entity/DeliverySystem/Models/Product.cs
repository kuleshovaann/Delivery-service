using System;
using DeliverySystem.Enums;

namespace DeliverySystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductСategory ProductСategory { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public int Count { get; set; }
        public double Weight { get; set; }
    }
}
