using System;
using Models.Contracts;
using Models.UI;
using Models.Models;

namespace Models.Services
{
    public class CompanyServices
    {
        public static void СompanyActions(ICompany company)
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

        public static void AddDish(ICompany company, string name, double price, string composition, double weight, int calories)
        {
            company.Menu.Add(new Dish()
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
