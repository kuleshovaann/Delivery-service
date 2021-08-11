using System;
using DeliverySystem.DataBase;
using System.Linq;

namespace DeliverySystem.Services
{
    public class LinqRequests
    {
        private ProviderDataBase _providerDataBase;
        private ProductDataBase _productDataBase;
        public LinqRequests(ProviderDataBase providerDataBase, ProductDataBase productDataBase)
        {
            _providerDataBase = providerDataBase;
            _productDataBase = productDataBase;
            Method1();
            Method2();
            Method3();
            Method4();
            Method5_1();
            Method5_2();
        }

        public void Method1()
        {
            Console.WriteLine("1");

            var products = _productDataBase.Products.Select(u => u.Name).OrderBy(i => i).ToList();

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void Method2()
        {
            Console.WriteLine("2");

            var products = _productDataBase.Products.Select(e => e.Name + " | " + e.Provider).ToList();

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void Method3()
        {
            Console.WriteLine("3");

            var categories = _productDataBase.Products.GroupBy(u => u.ProductСategory).Select(x => new { categoryName = x.Key, count = x.Count()}).ToList();

            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }
        }

        public void Method4()
        {
            Console.WriteLine("4");

            var providers = _providerDataBase.Providers.OrderByDescending(u => u.Products.Count).ToList();

            foreach (var provider in providers)
            {
                Console.WriteLine(provider.Name);
            }
        }

        public void Method5_1()
        {
            Console.WriteLine("5.1");

            var productsProvider1 = _productDataBase.Products.Where(x => x.Provider == "Sun Cup").Select(u => u.Name).ToList();/*.Select(u => u.Name);*/
            var productsProvider2 = _productDataBase.Products.Where(x => x.Provider == "Dress for you").Select(u => u.Name).ToList();

            var products = productsProvider1.Intersect(productsProvider2);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void Method5_2()
        {
            Console.WriteLine("5.2");

            var productsProvider1 = _productDataBase.Products.Where(x => x.Provider == "Sun Cup").Select(u => u.Name).ToList();
            var productsProvider2 = _productDataBase.Products.Where(x => x.Provider == "Dress for you").Select(u => u.Name).ToList();

            var products = productsProvider1.Except(productsProvider2);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
