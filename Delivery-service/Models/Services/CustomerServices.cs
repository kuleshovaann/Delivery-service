using System;
using DeliveryService.Contracts;
using DeliveryService.Models;

namespace DeliveryService.Services
{
    public class CustomerServices : ICustomerServices
    {
        private IOrderServices _orderServices;
        private IOrderDatabase _orderDatabase;

        public CustomerServices(IOrderServices orderServices, IOrderDatabase orderDatabase)
        {
            _orderServices = orderServices;
            _orderDatabase = orderDatabase;
        }

        public Order MakeOrder(Company restraunt, Customer customer, int index)
        {
            var order = new Order();

            while (index != 0)
            {
                _orderServices.AddToOrder(restraunt, order, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            _orderDatabase.Orders.Add(order);
            return order;
        }
    }
}
