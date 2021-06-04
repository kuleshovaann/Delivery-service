using System;
using System.Collections.Generic;
using DeliveryService.Models;

namespace DeliveryService.Contracts
{
    public interface ICompanyServices
    {
        void CompanyActions(Company company) { }

        void AddDish(Company company, string name, double price, string composition, double weight, int calories) { }
    }
}
