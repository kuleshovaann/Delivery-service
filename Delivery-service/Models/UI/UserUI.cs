using System;
using System.Text.RegularExpressions;
using DeliveryService.Contracts;
using DeliveryService.Models;

namespace DeliveryService.UI
{
    public class UserUI
    {
        private ICompanyServices _companyServices;
        private IOrderServices _orderServices;
        private IOrderDatabase _orderDatabase;

        public UserUI(IOrderServices orderServices,
                      ICompanyServices companyServices,
                      IOrderDatabase orderDatabase)
        {
            _orderServices = orderServices;
            _companyServices = companyServices;
            _orderDatabase = orderDatabase;
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
                        MakeOrderUI(company, customer);
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

            var choice = int.TryParse(Console.ReadLine(), out int number);
            switch (number)
            {
                case 1:
                    AddDishUI(company);
                    break;
                case 2:
                    ShowMenu(company);
                    break;
                default:
                    Console.WriteLine("Please, start again.");
                    break;
            }
        }

        public void MakeOrderUI(Company restraunt, Customer customer)
        {
            Console.WriteLine("Select dish or drink number or enter 0 for finish");
            ShowMenu(restraunt);

            int index = int.Parse(Console.ReadLine());
            var order = new Order();

            while(index != 0)
            {
                _orderServices.AddToOrder(restraunt, order, index);
                GetVerificationOrder(restraunt, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            order.Phone = GetPhone();
            order.Address = GetAddress();

            _orderDatabase.Orders.Add(order);
            ShowFullPrice(order);
        }

        public string GetPhone()
        {
            Console.WriteLine("Enter your phone in the format: +380(95)222 33 88 or +380952223388, or 0952223388, or 095 222 33 88.");
            var number = Convert.ToString(Console.ReadLine());

            if (GetVerificationPhone(number))
            {
                return number;
            }

            return null;
        }

        public bool GetVerificationPhone(string numberPhone)
        {
            var pattern = @"\+?(38)?0\(?\d{2}\)?\s?\d{3}\s?\d{2}\s?\d{2}";
            var expression = new Regex(pattern, RegexOptions.Compiled);

            return expression.IsMatch(numberPhone);
        }

        public string GetAddress()
        {
            Console.WriteLine("Enter your address: ");
            var address = Convert.ToString(Console.ReadLine());

            if (GetVerificationAddress(address))
            {
                return address;
            }

            return null;
        }

        public bool GetVerificationAddress(string address)
        {
            var pattern = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\s?(?:д)(?:ом)?.?\s?\d*\,?\s?(?:кв)?\.?\s?(?:артира)?\s?\d*";
            var expression = new Regex(pattern, RegexOptions.Compiled);

            return expression.IsMatch(address);
        }

        public void ShowFullPrice(Order order)
        {
            Console.WriteLine("Your order:");
            foreach(Dish dish in order.Dishes)
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
