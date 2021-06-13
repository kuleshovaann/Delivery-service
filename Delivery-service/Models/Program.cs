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

            var orderDatabase = new OrderDatabase();
            var orderServices = new OrderServices(orderDatabase);
            var companyServices = new CompanyServices(orderDatabase, logger);

            var company = new Company();
            companyServices.AddDish(company, "Coffee", 40.0, "Instant coffee", 150, 15);
            companyServices.AddDish(company, "Black tea", 40.0, "Ceylon long leaf tea", 250, 1);
            companyServices.AddDish(company, "Green tea", 40.0, "Green tea leaves", 250, 1);
            Console.Clear();

            var customer = new Customer();
            var user = new UserUI(orderServices, companyServices, orderDatabase, logger);
            user.StartUI(company, customer);
        }
    }
}
