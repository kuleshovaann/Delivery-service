using System;
using DeliveryService.Contracts;
using DeliveryService.Models;

namespace DeliveryService.Services
{
    public class CustomerServices : ICustomerServices
    {
        private IOrderServices _orderServices;
        private IOrderDatabase _orderDatabase;
        private ILogger _logger;
        private ISerializator _serializator;

        public CustomerServices(IOrderServices orderServices,
                                IOrderDatabase orderDatabase,
                                ILogger logger,
                                ISerializator serializator)
        {
            _orderServices = orderServices;
            _orderDatabase = orderDatabase;
            _logger = logger;
            _serializator = serializator;
        }

        public Order MakeOrder(Company restraunt, Customer customer)
        {
            var order = _serializator.DeserializeDataOrder();
            int index = int.Parse(Console.ReadLine());

            while (index != 0)
            {
                _orderServices.AddToOrder(restraunt, order, index);
                Console.WriteLine();

                index = int.Parse(Console.ReadLine());
            }

            _orderDatabase.Orders.Add(order);
            _logger.CreateNewNote("New order has been created");
            _serializator.SerializeDataOrder(order);

            return order;
        }
    }
}
