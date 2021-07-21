using System;
using System.Collections.Generic;
using DeliverySystem.Conctracts;

namespace DeliverySystem.Models
{
    public class Provider : IProvider
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public Сategory ProviderСategory { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public enum Сategory
        {
            FoodStore,
            Restaurant,
            OnlineStore
        }
    }
}
