using System;
using DeliveryService.Models;
using DeliveryService.UI;
using DeliveryService.Services;
using DeliveryService.Database;

namespace DeliveryService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logger = new Logger();
            var serializer = new FileServices();
            var company = serializer.GetFromFileDataCompany();

            var orderDatabase = new OrderDatabase(serializer);
            var orderServices = new OrderServices(orderDatabase);
            var companyServices = new CompanyServices(orderDatabase, logger, serializer);

            if (company.Dishes.Count == 0)
            {
                companyServices.GetStartMenu(company);
            }

            var customer = new Customer();
            var user = new UserUI(orderServices, companyServices, orderDatabase, logger);
            user.StartUI(company, customer);
        }
    }
}
