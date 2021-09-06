using System;

namespace DeliverySystem.DAL.Models
{
    public class DeliveryProduct : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public double Price { get; set; }
    }
}
