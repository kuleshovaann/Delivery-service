using System;
using DeliveryService.Contracts;
using DeliveryService.Models;
using DeliveryService.Services;

namespace DeliveryService.UI
{
    public class UserUI
    {
        public static void StartUI()
        {
            Console.WriteLine("Сontinue as:");
            Console.WriteLine("1 - company");
            Console.WriteLine("2 - customer");
        }

        public static void AddDishUI(Company company)
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

            CompanyServices.AddDish(company, name, price, composition, weight, calories);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dish has been added to the menu");
            Console.ResetColor();
        }

        public static void ShowMenu(Company company)
        {
            var count = 1;
            foreach (var dish in company.Dishes)
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

        public static void СompanyActionsUI(Company company)
        {
            Console.WriteLine("1 - Adding a new dish");
            Console.WriteLine("2 - View menu");

            CompanyServices.CompanyActions(company);
        }

        public static void СustomerActionsUI()
        {
            Console.WriteLine("Select dish or drink number or enter 0 for finish"); ;
        }

        public static void ShowFullPrice(Order order)
        {
            Console.WriteLine($"Order amount: {order.FullPrice}");
        }

        public static void GetVerificationOrder(Company company, int index)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{company.Dishes[index - 1].Name} has been added to the order");
            Console.ResetColor();
        }

        public static void GetPhoneUI()
        {
            Console.WriteLine("Enter your phone in the format: +380(95)222 33 88 or +380952223388, or 0952223388, or 095 222 33 88.");
        }

        public static void GetAddressUI()
        {
            Console.WriteLine("Enter your address in the format: ");
        }
    }
}
