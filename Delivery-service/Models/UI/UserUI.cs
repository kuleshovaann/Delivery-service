using System;
using DeliveryService.Contracts;
using DeliveryService.Models;

namespace DeliveryService.UI
{
    public class UserUI
    {
        private ICustomerServices _customerServices;
        private ICompanyServices _companyServices;

        public UserUI(ICustomerServices customerServices,
                      ICompanyServices companyServices)
        {
            _customerServices = customerServices;
            _companyServices = companyServices;
        }

        public void StartUI(Company company, Customer customer)
        {
            while (true)
            {
                Console.WriteLine("Сontinue as:");
                Console.WriteLine("1 - company");
                Console.WriteLine("2 - customer");

                var choice = int.TryParse(Console.ReadLine(), out int number);

                switch (number)
                {
                    case 1:
                        СompanyActionsUI(company);
                        break;
                    case 2:
                        СustomerActionsUI(company, customer);
                        break;
                    default:
                        Console.WriteLine("Please, start again.");
                        break;
                }
                Console.WriteLine("----------------------");
            }
        }

        public void AddDishUI(Company company)
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

            _companyServices.AddDish(company, name, price, composition, weight, calories);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dish has been added to the menu");
            Console.ResetColor();
        }

        public void ShowMenu(Company company)
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

        public void СompanyActionsUI(Company company)
        {
            Console.WriteLine("1 - Adding a new dish");
            Console.WriteLine("2 - View menu");
            Console.WriteLine("3 - Remove a dish from the menu");

            var choice = int.TryParse(Console.ReadLine(), out int number);
            switch (number)
            {
                case 1:
                    AddDishUI(company);
                    break;
                case 2:
                    ShowMenu(company);
                    break;
                case 3:
                    DeleteDishUI(company);
                    break;
                default:
                    Console.WriteLine("Please, start again.");
                    break;
            }
        }

        public void DeleteDishUI(Company company)
        {
            Console.WriteLine("Select dish number for remove:");
            ShowMenu(company);

            _companyServices.DeleteDish(company);
        }

        public void СustomerActionsUI(Company restraunt, Customer customer)
        {
            Console.WriteLine("Select dish or drink number or enter 0 for finish");
            ShowMenu(restraunt);

            var order = _customerServices.MakeOrder(restraunt, customer);
            ShowFullPrice(order);
        }

        public void ShowFullPrice(Order order)
        {
            Console.WriteLine("Your order:");
            foreach (Dish dish in order.Dishes)
            {
                Console.WriteLine($"{dish.Name}");
            }

            Console.WriteLine($"Order amount: {order.FullPrice}");
        }

        public void GetVerificationOrder(Company company, int index)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{company.Dishes[index - 1].Name} has been added to the order");
            Console.ResetColor();
        }
    }
}
