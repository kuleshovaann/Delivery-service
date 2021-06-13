using System;
using DeliveryService.Models;
using DeliveryService.Contracts;

namespace DeliveryService.Services
{
    public class OrderServices : IOrderServices
    {
        private IOrderDatabase _orderDatabase;

        public OrderServices(IOrderDatabase orderDatabase)
        {
            _orderDatabase = orderDatabase;
        }

        public void AddToOrder(Company company, Order order, int index)
        {
            if (index <= company.Dishes.Count)
            {
                order.Dishes.Add(new Dish()
                {
                    Name = company.Dishes[index - 1].Name,
                    Price = company.Dishes[index - 1].Price,
                    Сomposition = null,
                    Weight = 0.0,
                    Calories = 0
                });

                order.FullPrice += company.Dishes[index - 1].Price;
            }
        }

        public void AddToDataBase(Order order)
        {
            _orderDatabase.Orders.Add(order);
        }
    }
}
