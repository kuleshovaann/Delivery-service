using System;
using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface IFileServices
    {
        void SaveToFlieDataCompany(Company company);

        Company GetFromFileDataCompany();

        void SaveToFlieDataOrder(Order order);

        Order GetFromFileDataOrder();
    }
}
