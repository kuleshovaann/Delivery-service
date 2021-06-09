using System;
using DeliveryService.Models;
using DeliveryService.UI;
using DeliveryService.Services;
using DeliveryService.Database;
using System.Linq;

namespace DeliveryService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logger = new Logger();
            var serializer = new Serializator();
            var company = serializer.DeserializeDataCompany();

            var customer = new Customer();
            var orderServices = new OrderServices();
            var orderDatabase = new OrderDatabase();
            var customerServices = new CustomerServices(orderServices, orderDatabase, logger, serializer);
            var companyServices = new CompanyServices(orderDatabase, logger, serializer);

            if (company.Dishes.Count == 0)
            {
                companyServices.GetStartMenu(company);
            }

            var user = new UserUI(customerServices, companyServices);
            user.StartUI(company, customer);
        }
    }
}
