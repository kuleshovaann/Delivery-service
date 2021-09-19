using Microsoft.AspNetCore.Mvc;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Delivery_Service.API.Filters;
using System;

namespace Delivery_Service.API.Controllers
{
    [Route("mvc/product")]
    [ServiceFilter(typeof(NewExceptionFilter))]
    public class ProductMVCController : Controller
    {
        private readonly IProductServices _productServices;
        private readonly IProviderServices _providerServices;

        public ProductMVCController(IProductServices productService, IProviderServices providerServices)
        {
            _productServices = productService;
            _providerServices = providerServices;
        }

        [HttpGet]
        [ServiceFilter(typeof(RequestBodyActionFilter))]
        public IActionResult GetProducts()
        {
            return View();
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            ViewBag.Providers = new SelectList(_providerServices.GetAllProviders(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("GetProducts");
            }

            _productServices.CreateProduct(product);

            return RedirectToAction("GetProducts");
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            Product product = _productServices.GetProductById(id);
            ViewBag.Providers = new SelectList(_providerServices.GetAllProviders(), "Id", "Name");

            return View(product);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(Product product)
        {
            _productServices.EditProduct(product);

            return RedirectToAction("GetProducts");
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _productServices.DeleteProduct(id);

            return RedirectToAction("GetProducts");
        }
    }
}
