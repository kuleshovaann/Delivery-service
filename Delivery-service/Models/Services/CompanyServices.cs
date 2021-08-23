using DeliveryService.Models;
using DeliveryService.Contracts;
using System;
using System.Collections.Generic;

namespace DeliveryService.Services
{
    public class CompanyServices : ICompanyServices
    {
        private IOrderDatabase _orderDatabase;
        private ILogger _logger;
        private IFileServices _serializator;

        public CompanyServices(IOrderDatabase orderDatabase, ILogger logger, IFileServices serializator)
        {
            _orderDatabase = orderDatabase;
            _logger = logger;
            _serializator = serializator;
        }

        public void AddDish(Company company, string name, double price, string composition, double weight, int calories)
        {
            company.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Composition = composition,
                Weight = weight,
                Calories = calories
            });

            _logger.Log($"The dish *{name}* has been added to the menu");

            _orderDatabase.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Composition = composition,
                Weight = weight,
                Calories = calories
            });

            _logger.Log($"The dish *{name}* has been added to the base of dishes");
        }

        public void DeleteDish(Company company, int index)
        {
            _logger.Log($"The dish *{company.Dishes[index - 1].Name}* has been removed from the menu");
            company.Dishes.RemoveAt(index - 1);
            _orderDatabase.Dishes.RemoveAt(index - 1);
        }

        public void GetStartMenu(Company company)
        {
            company.Dishes.Add(new Dish() { Name = "Coffee", Price = 40.0, Composition = "Instant coffee", Weight = 90, Calories = 1 });
            company.Dishes.Add(new Dish() { Name = "Black tea", Price = 30.0, Composition = "Ceylon long leaf tea", Weight = 200, Calories = 0 });
            company.Dishes.Add(new Dish() { Name = "Green tea", Price = 30.0, Composition = "Green tea leaves", Weight = 200, Calories = 0 });
            Console.Clear();

            _serializator.SaveToFlieDataCompany(company);
        }

        //mothod for TASK 1 ASP
        public IEnumerable<Dish> GetMenu()
        {
            var menu = new List<Dish>();
            menu.Add(new Dish() { Name = "Coffee", Price = 40.0, Composition = "Instant coffee", Weight = 90, Calories = 1 });
            menu.Add(new Dish() { Name = "Black tea", Price = 30.0, Composition = "Ceylon long leaf tea", Weight = 200, Calories = 0 });
            menu.Add(new Dish() { Name = "Green tea", Price = 30.0, Composition = "Green tea leaves", Weight = 200, Calories = 0 });

            return menu;
        }
    }
}
