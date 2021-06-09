using DeliveryService.Models;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using DeliveryService.Contracts;


namespace DeliveryService.Services
{
    public class Serializator : ISerializator
    {
        private string _pathCompany;
        private string _pathOrder;

        public Serializator()
        {
            _pathCompany = AppDomain.CurrentDomain.BaseDirectory +
                "DishesDatabaseJson.json";

            _pathOrder = AppDomain.CurrentDomain.BaseDirectory +
                "OrdersDatabaseJson.json";
        }

        public void SerializeDataCompany(Company company)
        {
            var serialized = JsonSerializer.Serialize(company);

            using var file = new FileStream(_pathCompany, FileMode.Create);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.Write(serialized);

            Console.WriteLine(serialized);
        }

        public Company DeserializeDataCompany()
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

        public void SerializeDataOrder(Order order)
        {
            var serialized = JsonSerializer.Serialize(order);

            using var file = new FileStream(_pathOrder, FileMode.OpenOrCreate);
            using var stream = new StreamWriter(file, Encoding.UTF8);

            stream.Write(serialized);

            Console.WriteLine(serialized);
        }

        public Order DeserializeDataOrder()
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
