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
            Console.WriteLine();
            var company = new Company();
            company.Dishes.Add(new Dish() { Name = "Coffee", Price = 40.0, Сomposition = "Instant coffee", Weight = 90, Calories = 1});
            company.Dishes.Add(new Dish() { Name = "Black tea", Price = 30.0, Сomposition = "Ceylon long leaf tea", Weight = 200, Calories = 0});
            company.Dishes.Add(new Dish() { Name = "Green tea", Price = 30.0, Сomposition = "Green tea leaves", Weight = 200, Calories = 0});
            Console.Clear();

            var logger = new Logger();

            var customer = new Customer();
            var orderServices = new OrderServices();
            var orderDatabase = new OrderDatabase();
            var customerServices = new CustomerServices(orderServices, orderDatabase, logger);
            var companyServices = new CompanyServices(orderDatabase, logger);

            var user = new UserUI(customerServices, companyServices);
            user.StartUI(company, customer);
        }
    }
}
