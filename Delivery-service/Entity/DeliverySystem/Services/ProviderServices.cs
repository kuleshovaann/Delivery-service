using System;
using System.Collections.Generic;
using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Contracts;

namespace DeliverySystem.DAL.Services
{
    public class ProviderServices : IProviderServices
    {
        private UnitOfWork _unitOfWork;

        public ProviderServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Provider> GetAllProviders()
        {
            return _unitOfWork.Providers.GetAll();
        }

        public Provider GetProviderById(int id)
        {
            return _unitOfWork.Providers.Get(id);
        }

        public void CreateProvider(Provider provider)
        {
            _unitOfWork.Providers.Create(provider);
        }

        public Provider EditProvider(Provider provider)
        {
            return _unitOfWork.Providers.Update(provider);
        }

        public void DeleteProvider(int id)
        {
            _unitOfWork.Providers.Delete(id);
        }
    }
}
