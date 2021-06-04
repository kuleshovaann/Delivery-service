using DeliveryService.Models;
using System;

namespace DeliveryService.Contracts
{
    public interface IStarter
    {
        void Start(Company company, Customer customer);
    }
}
