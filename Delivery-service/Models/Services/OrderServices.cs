using System;
using DeliveryService.Models;
using DeliveryService.UI;
using DeliveryService.Contracts;

namespace DeliveryService.Services
{
    public class OrderServices : IOrderServices
    {
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
    }
}
