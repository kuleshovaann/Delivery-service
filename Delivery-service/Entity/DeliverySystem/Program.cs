using System;
using DeliverySystem.Models;

namespace DeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateData();


        }

        public static void CreateData()
        {
            var provider1 = new Provider();
            provider1.Name = "SunCup";
            provider1.ProviderСategory = Provider.Сategory.Restaurant;

            provider1.Products.Add(new Product()
            {
                Name = "Coffee",
                ProductСategory = Product.Сategory.Food,
                Price = 40.0,
                Description = "Instant coffee",
                Count = 1000,
                Weight = 200
            });

            provider1.Products.Add(new Product()
            {
                Name = "Black tea",
                ProductСategory = Product.Сategory.Food,
                Price = 40.0,
                Description = "Ceylon long leaf tea",
                Count = 1000,
                Weight = 250
            });

            provider1.Products.Add(new Product()
            {
                Name = "Green tea",
                ProductСategory = Product.Сategory.Food,
                Price = 40.0,
                Description = "Green tea leave",
                Count = 1000,
                Weight = 250
            });
        }
    }
}
