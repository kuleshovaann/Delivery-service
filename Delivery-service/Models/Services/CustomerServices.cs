using System;
using DeliveryService.Contracts;
using DeliveryService.Models;
using DeliveryService.UI;
using DeliveryService.Database;

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

            var newOrder = new OrderDatabase();
            newOrder.Orders.Add(order);
            UserUI.ShowFullPrice(order);
        }
    }
}
