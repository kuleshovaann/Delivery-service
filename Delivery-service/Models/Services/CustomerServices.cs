using System;
using DeliveryService.Contracts;
using DeliveryService.Models;
using DeliveryService.UI;
using DeliveryService.Database;
using System.Text.RegularExpressions;

namespace DeliveryService.Services
{
    public class CustomerServices : ICustomerServices
    {
        public static void СustomerActions(Company restraunt, Customer customer)
        {
            UserUI.СustomerActionsUI();
            UserUI.ShowMenu(restraunt);

            MakeOrder(restraunt, customer);
        }

        public static void MakeOrder(Company restraunt, Customer customer)
        {
            var order = new Order();
            int index = int.Parse(Console.ReadLine());

            while (index != 0)
            {
                OrderServices.AddToOrder(restraunt, order, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            order.Phone = GetPhone();
            order.Address = GetAddress();

            var newOrder = new OrderDatabase();
            OrderDatabase.AddToOrderDataBase(newOrder, order);
            UserUI.ShowFullPrice(order);
        }

        public static string GetPhone()
        {
            UserUI.GetPhoneUI();
            var number = Convert.ToString(Console.ReadLine());

            if (GetVerificationPhone(number))
            {
                return number;
            }

            return null;
        }

        public static string GetAddress()
        {
            UserUI.GetAddressUI();
            var address = Convert.ToString(Console.ReadLine());

            if (GetVerificationAddress(address))
            {
                return address;
            }

            return null;
        }

        public static bool GetVerificationPhone(string number)
        {
            var pattern = @"\+?(38)?0\(?\d{2}\)?\s?\d{3}\s?\d{2}\s?\d{2}";
            var expression = new Regex(pattern, RegexOptions.Compiled);

            return expression.IsMatch(number);
        }

        public static bool GetVerificationAddress(string address)
        {
            var pattern = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\s?(?:д)(?:ом)?.?\s?\d*\,?\s?(?:кв)?\.?\s?(?:артира)?\s?\d*";
            var expression = new Regex(pattern, RegexOptions.Compiled);

            return expression.IsMatch(address);
        }
    }
}
