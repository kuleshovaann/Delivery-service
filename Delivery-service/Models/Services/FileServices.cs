using DeliveryService.Models;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using DeliveryService.Contracts;


namespace DeliveryService.Services
{
    public class FileServices : IFileServices
    {
        private string _pathCompany;
        private string _pathOrder;

        public FileServices()
        {
            _pathCompany = AppDomain.CurrentDomain.BaseDirectory +
                "DishesDatabaseJson";

            _pathOrder = AppDomain.CurrentDomain.BaseDirectory +
                "OrdersDatabaseJson";
        }

        public void SaveToFlieDataCompany(Company company)
        {
            var serialized = JsonSerializer.Serialize(company);

            using var file = new FileStream(_pathCompany, FileMode.Create);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.Write(serialized);

            Console.WriteLine(serialized);
        }

        public Company GetFromFileDataCompany()
        {
            if (File.Exists(_pathCompany))
            {
                using var file = new FileStream(_pathCompany, FileMode.Open);
                using var stream = new StreamReader(file, Encoding.UTF8);

                var company = stream.ReadToEnd();

                return JsonSerializer.Deserialize<Company>(company);
            }

            return new Company();
        }

        public void SaveToFlieDataOrder(Order order)
        {
            var serialized = JsonSerializer.Serialize(order);

            using var file = new FileStream(_pathOrder, FileMode.OpenOrCreate);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.Write(serialized);
        }

        public Order GetFromFileDataOrder()
        {
            if (File.Exists(_pathOrder))
            {
                using var file = new FileStream(_pathOrder, FileMode.Open);
                using var stream = new StreamReader(file, Encoding.UTF8);

                var order = stream.ReadToEnd();

                return JsonSerializer.Deserialize<Order>(order);
            }

            return new Order();
        }
    }
}
