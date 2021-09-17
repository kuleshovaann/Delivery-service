using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Contracts;

using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Services
{
    public class OrderServices : IOrderServices
    {
        private UnitOfWork _unitOfWork;

        public OrderServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _unitOfWork.Orders.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _unitOfWork.Orders.Get(id);
        }

        public void CreateOrder(Order order)
        {
            _unitOfWork.Orders.Create(order);
        }

        public Order EditOrder(Order order)
        {
            return _unitOfWork.Orders.Update(order);
        }

        public void DeleteOrder(int id)
        {
            _unitOfWork.Orders.Delete(id);
        }
    }
}
