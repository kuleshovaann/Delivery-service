﻿using DeliveryService.Models;
using DeliveryService.Contracts;
using System;

namespace DeliveryService.Services
{
    public class CompanyServices : ICompanyServices
    {
        private IOrderDatabase _orderDatabase;
        private ILogger _logger;

        public CompanyServices(IOrderDatabase orderDatabase, ILogger logger)
        {
            _orderDatabase = orderDatabase;
            _logger = logger;
        }

        public void AddDish(Company company, string name, double price, string composition, double weight, int calories)
        {
            company.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Сomposition = composition,
                Weight = weight,
                Calories = calories
            });

            _logger.Log($"The dish *{name}* has been added to the menu");

            _orderDatabase.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Сomposition = composition,
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
    }
}
