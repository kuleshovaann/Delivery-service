using System;
using System.Collections.Generic;
using DeliverySystem.DAL.Enums;

namespace DeliverySystem.DAL.Models
{
    public class Provider : BaseModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public ProviderType ProviderType { get; set; }       
    }
}
