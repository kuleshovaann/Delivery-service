using DeliveryService.Contracts;
using System.Collections.Generic;
using DeliveryService.Models;

namespace DeliveryService.Database
{
    public class OrderDatabase : IOrderDatabase
    {
        private IFileServices _serializator;

        public OrderDatabase(IFileServices serializator)
        {
            _serializator = serializator;
        }

        public List<Order> Orders { get; set; } = new List<Order>();

        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public void Save(Order order)
        {
            _serializator.SaveToFlieDataOrder(order);
        }
    }
}
