using System;
using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ICustomerServices
    {
        void СustomerActions(Company restraunt, Customer customer) { }

        void MakeOrder(Company restraunt, Customer customer) { }
    }
}
