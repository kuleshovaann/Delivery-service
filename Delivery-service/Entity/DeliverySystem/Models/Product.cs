using System;
using DeliverySystem.DAL.Enums;

namespace DeliverySystem.DAL.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public ProductСategory ProductСategory { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public int Count { get; set; }
        public double Weight { get; set; }
    }
}
