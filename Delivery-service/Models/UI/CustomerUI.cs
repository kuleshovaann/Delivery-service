using System;
using Models.Models;
using Models.Services;
using Models.Contracts;

namespace Models.UI
{
    class CustomerUI
    {
        public static void СustomerActions(ICompany restraunt, ICustomer customer)
        {
            var order = new Order();
            int index;

            Console.WriteLine("Select dish or drink number or enter 0 for finish");
            CompanyServices.ShowMenu(restraunt);

            index = int.Parse(Console.ReadLine());

            while (index != 0)
            {
                OrderServices.AddToOrder(restraunt, order, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Order amount: {order.FullPrice}");
        }
    }
}
