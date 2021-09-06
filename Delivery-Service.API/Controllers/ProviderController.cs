using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderController : Controller
    {
        private readonly IProviderServices _providerServices;

        public ProviderController(IProviderServices providerServices)
        {
            _providerServices = providerServices;
        }

        [HttpGet]
        public IEnumerable<Provider> GetAll()
        {
            return _providerServices.GetAllProviders();
        }

        [HttpGet("{id}")]
        public Provider GetById(int id)
        {
            return _providerServices.GetProviderById(id);
        }

        [HttpPost("{provider}")]
        public void CreateProvider(Provider provider)
        {
            _providerServices.CreateProvider(provider);
        }

        [HttpPut("{provider}")]
        public void EditProvider(Provider provider)
        {
            _providerServices.EditProvider(provider);
        }

        [HttpDelete("{id}")]
        public void DeleteProvider(int id)
        {
            _providerServices.DeleteProvider(id);
        }
    }
}
