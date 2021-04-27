using System;
using Models.Models;

namespace Models.Services
{
    public class OrderServices
    {
        public static void AddToOrder(Company company, Order order, int index)
        {
            order.Titles.Add(new Dish()
            {
                Name = company.Menu[index - 1].Name,
                Price = company.Menu[index - 1].Price,
                Сomposition = null,
                Weight = 0.0,
                Calories = 0
            });

            order.FullPrice += company.Menu[index - 1].Price;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{company.Menu[index - 1].Name} has been added to the order");
            Console.ResetColor();
        }
    }
}
