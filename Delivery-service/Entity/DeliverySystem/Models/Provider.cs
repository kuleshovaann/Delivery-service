using System;
using System.Collections.Generic;
using DeliverySystem.Enums;

namespace DeliverySystem.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public ProviderType ProviderType { get; set; }       
    }
}
