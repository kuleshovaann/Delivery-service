using DeliverySystem.DAL.Models;
using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Contracts
{
    public interface IOrderServices
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        void CreateOrder(Order order);
        Order EditOrder(Order order);
        void DeleteOrder(int id);
    }
}
