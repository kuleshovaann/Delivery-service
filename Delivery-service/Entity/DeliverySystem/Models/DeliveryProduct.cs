using System;
using System.Collections.Generic;


namespace DeliverySystem.Models
{
    public class DeliveryProduct
    {
        public DeliveryProduct(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            Provider = product.Provider.Name;
            Price = product.Price;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Provider { get; set; }

        public double Price { get; set; }


    }
}
