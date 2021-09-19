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

        [HttpPost]
        public IActionResult CreateProvider(Provider provider)
        {
            _providerServices.CreateProvider(provider);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditProvider(Provider provider)
        {
            _providerServices.EditProvider(provider);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProvider(int id)
        {
            _providerServices.DeleteProvider(id);
            return Ok();
        }
    }
}
