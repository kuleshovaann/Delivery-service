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
            var pattern = @"\+\d{3}\(\d{2}\)\d{3}\s\d{2}\s\d{2}";
            var pattern2 = @"\+\d{12}";
            var pattern3 = @"0\d{9}";
            var pattern4 = @"0\d{2}\s\d{3}\s\d{2}\s\d{2}";

            var expression = new Regex(pattern, RegexOptions.Compiled);
            var expression2 = new Regex(pattern2, RegexOptions.Compiled);
            var expression3 = new Regex(pattern3, RegexOptions.Compiled);
            var expression4 = new Regex(pattern4, RegexOptions.Compiled);

            if (expression.IsMatch(number)
                || expression2.IsMatch(number)
                || expression3.IsMatch(number)
                || expression4.IsMatch(number))
            {
                return true;
            }

            return false;
        }

        public static bool GetVerificationAddress(string address)
        {
            var pattern = @"(?:улица|ул\.?)\s?[А-Я][а-я]*\.?\,?\?:д|дом\.?\s?\d\,?\s?\?:кв|квартира.?\s?\d";
            var expression = new Regex(pattern, RegexOptions.Compiled);

            if (expression.IsMatch(address))
            {
                return true;
            }

            return true;
        }
    }
}
