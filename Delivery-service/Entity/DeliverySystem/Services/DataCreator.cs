using System;
using DeliverySystem.Models;
using DeliverySystem.Enums;
using DeliverySystem.DataBase;

namespace DeliverySystem.Services
{
    public class DataCreator
    {
        private ProviderDataBase _providerDataBase { get; set; }
        private ProductDataBase _productDataBase { get; set; }

        public DataCreator(ProviderDataBase providerDataBase, ProductDataBase productDataBase)
        {
            _providerDataBase = providerDataBase;
            _productDataBase = productDataBase;
            CreateData();
        }

        public void CreateData()
        {
            var provider1 = new Provider();
            provider1.Name = "Sun Cup";
            provider1.ProviderType = ProviderType.Restaurant;

            provider1.Products.Add(new Product()
            {
                Name = "Coffee",
                ProductСategory = ProductСategory.Food,
                Price = 50.0,
                Description = "Instant coffee",
                Provider = provider1.Name,
                Count = 1000,
                Weight = 200
            });

            provider1.Products.Add(new Product()
            {
                Name = "Black tea",
                ProductСategory = ProductСategory.Food,
                Price = 40.0,
                Description = "Ceylon long leaf tea",
                Provider = provider1.Name,
                Count = 1000,
                Weight = 250
            });

            provider1.Products.Add(new Product()
            {
                Name = "Green tea",
                ProductСategory = ProductСategory.Food,
                Price = 40.0,
                Description = "Green tea leave",
                Provider = provider1.Name,
                Count = 1000,
                Weight = 250
            });

            provider1.Products.Add(new Product()
            {
                Name = "Сocoa",
                ProductСategory = ProductСategory.Food,
                Price = 45.0,
                Description = "Organic cacao powder with milk",
                Provider = provider1.Name,
                Count = 500,
                Weight = 300
            });

            _providerDataBase.Providers.Add(provider1);

            foreach(var product in provider1.Products)
            {
                _productDataBase.Products.Add(product);
            }

            var provider2 = new Provider();
            provider2.Name = "Dress for you";
            provider2.ProviderType = ProviderType.OnlineStore;

            provider2.Products.Add(new Product()
            {
                Name = "Coffee",
                ProductСategory = ProductСategory.Food,
                Price = 50.0,
                Description = "Instant coffee",
                Provider = provider2.Name,
                Count = 1000,
                Weight = 200
            });

            provider2.Products.Add(new Product()
            {
                Name = "Blouse",
                ProductСategory = ProductСategory.Dress,
                Price = 300.0,
                Description = "Summer blouse made of natural fabric",
                Provider = provider2.Name,
                Count = 5
            });

            provider2.Products.Add(new Product()
            {
                Name = "Jeans",
                ProductСategory = ProductСategory.Dress,
                Price = 550.0,
                Description = "Fashion flared jeans",
                Provider = provider2.Name,
                Count = 3
            });

            provider2.Products.Add(new Product()
            {
                Name = "T-shirt",
                ProductСategory = ProductСategory.Dress,
                Price = 350.0,
                Description = "Pastel T-shirt",
                Provider = provider2.Name,
                Count = 15
            });

            _providerDataBase.Providers.Add(provider2);

            foreach (var product in provider2.Products)
            {
                _productDataBase.Products.Add(product);
            }
        }
    }
}
