using Models.Models;
using Models.Contracts;
using System;

namespace Models.Services
{
    public class CompanyServices
    {
        public static void AddDish(ICompany company)
        {
            Console.WriteLine("Enter name:");
            var name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter price:");
            var price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter composition:");
            var composition = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter weight in grams:");
            var weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter calories:");
            var calories = int.Parse(Console.ReadLine());

            company.Menu.Add(new Dish() { Name = name, Price = price, Сomposition = composition, Weight = weight, Calories = calories });

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dish has been added to the menu");
            Console.ResetColor();
        }

        public static void ShowMenu(ICompany company)
        {
            var count = 1;
            foreach (var dish in company.Menu)
            {
                Console.WriteLine($"{count}");
                Console.WriteLine($"Name: {dish.Name}");
                Console.WriteLine($"Price: {dish.Price}");
                Console.WriteLine($"Сomposition: {dish.Сomposition}");
                Console.WriteLine($"Weight: {dish.Weight}");
                Console.WriteLine($"Calories: {dish.Calories}");
                count++;
            }
        }
    }
}
