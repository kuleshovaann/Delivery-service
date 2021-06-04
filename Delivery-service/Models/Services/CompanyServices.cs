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
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    UserUI.AddDishUI(company);
                    break;
                case 2:
                    UserUI.ShowMenu(company);
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
