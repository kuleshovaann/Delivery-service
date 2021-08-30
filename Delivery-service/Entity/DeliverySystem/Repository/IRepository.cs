using DeliverySystem.Models;
using System;
using System.Collections.Generic;

namespace DeliverySystem.Repository
{
    public interface IRepository
    {
        List<Provider> GetCProviders();
        Provider GetProviderById(int id);
        void AddProvider(Provider provider);
        void UpdateProvider(string newName, int id);
        void DeleteProvider(int id);

    }
}
