using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;

namespace Delivery_Service.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpPost("{product}")]
        public void CreateProduct(Product product)
        {
            _productServices.CreateProduct(product);
        }

        [HttpPut("{product}")]
        public void EditProduct(Product product)
        {
            _productServices.EditProduct(product);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            _productServices.DeleteProduct(id);
        }
    }
}

