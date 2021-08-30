using System;

namespace DeliverySystem.Models
{
    public class DeliveryProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public double Price { get; set; }
    }
}
