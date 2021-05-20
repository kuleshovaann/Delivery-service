using System;
using Models.Contracts;
using Models.Models;
using Models.UI;
using Models.Database;

namespace Models.Services
{
    public class CustomerServices
    {
        public static void СustomerActions(ICompany restraunt, ICustomer customer)
        {
            UserUI.СustomerActionsUI();
            UserUI.ShowMenu(restraunt);

            CustomerServices.MakeOrder(restraunt, customer);
        }

        public static void MakeOrder(ICompany restraunt, ICustomer customer)
        {
            var order = new Order();
            int index;

            index = int.Parse(Console.ReadLine());

            while (index != 0)
            {
                OrderServices.AddToOrder(restraunt, order, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            var newOrder = new OrderDatabase();
            OrderDatabase.AddTOOrderDataBase(newOrder, order);
            UserUI.ShowFullPrice(order);
        }
    }
}
