using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productServices.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return _productServices.GetProductById(id);
        }

        [HttpPost]
        public IActionResult CreateCustomer(Product product)
        {
            _productServices.CreateProduct(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditCustomer(Product product)
        {
            _productServices.EditProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _productServices.DeleteProduct(id);
            return Ok();
        }
    }
}

