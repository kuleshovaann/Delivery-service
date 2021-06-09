using System;
using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ISerializator
    {
        void SerializeDataCompany(Company company);

        Company DeserializeDataCompany();

        void SerializeDataOrder(Order order);

        Order DeserializeDataOrder();
    }
}
