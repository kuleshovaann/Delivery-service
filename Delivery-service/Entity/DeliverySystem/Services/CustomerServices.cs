using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Contracts;
using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Services
{
    public class CustomerServices : ICustomerServices
    {
        private UnitOfWork _unitOfWork;

        public CustomerServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _unitOfWork.Customers.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _unitOfWork.Customers.Get(id);
        }

        public void DeleteCustomer(int id)
        {
            _unitOfWork.Customers.Delete(id);
        }

        public void CreateCustomer(Customer customer)
        {
            _unitOfWork.Customers.Create(customer);
        }

        public Customer EditCustomer(Customer customer)
        {
            return _unitOfWork.Customers.Update(customer);
        }
    }
}
