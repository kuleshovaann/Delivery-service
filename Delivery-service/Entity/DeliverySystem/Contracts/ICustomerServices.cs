using DeliverySystem.DAL.Models;
using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Contracts
{
    public interface ICustomerServices
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void DeleteCustomer(int id);
        void CreateCustomer(Customer customer);
        Customer EditCustomer(Customer customer);
    }
}
