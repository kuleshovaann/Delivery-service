using System;
using System.Collections.Generic;
using DeliverySystem.DAL.Models;

namespace DeliverySystem.DAL.Contracts
{
    public interface IProviderServices
    {
        IEnumerable<Provider> GetAllProviders();
        Provider GetProviderById(int id);
        void CreateProvider(Provider provider);
        Provider EditProvider(Provider provider);
        void DeleteProvider(int id);
    }
}
