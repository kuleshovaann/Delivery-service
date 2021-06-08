using System;
using DeliveryService.UI;
using DeliveryService.Models;
using DeliveryService.Contracts;

namespace DeliveryService.Services
{
    public class CompanyServices : ICompanyServices
    {
        public static void CompanyActions(Company company)
        {
            var choice = int.TryParse(Console.ReadLine(), out int number);
            switch (number)
            {
                case 1:
                    UserUI.AddDishUI(company);
                    break;
                case 2:
                    UserUI.ShowMenu(company);
                    break;
                default:
                    Console.WriteLine("Please, start again.");
                    break;
            }
        }

        public static void AddDish(Company company, string name, double price, string composition, double weight, int calories)
        {
            company.Dishes.Add(new Dish()
            {
                Name = name,
                Price = price,
                Сomposition = composition,
                Weight = weight,
                Calories = calories
            });
        }
    }
}
