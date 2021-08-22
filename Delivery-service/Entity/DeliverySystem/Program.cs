using System;
using DeliverySystem.Services;
using DeliverySystem.DataBase;
using DeliverySystem.Repository;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = Initialize();
            var repository = new RepositoryProvider(configuration.GetConnectionString("DefaultConnection"));
            var e = repository.GetProviderById(1);


            var providerDataBase = new ProviderDataBase();
            var productDataBase = new ProductDataBase();
            var creator = new DataCreator(providerDataBase, productDataBase);
            var linq = new LinqRequests(providerDataBase, productDataBase);

            Console.ReadKey();
        }

        private static IConfigurationRoot Initialize()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
