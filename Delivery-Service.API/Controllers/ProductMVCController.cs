using Microsoft.AspNetCore.Mvc;
using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Delivery_Service.API.Filters;
using System;

namespace Delivery_Service.API.Controllers
{
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
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 120)]
        public IActionResult GetProducts()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Providers = new SelectList(_providerServices.GetAllProviders(), "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productServices.CreateProduct(product);

            return RedirectToAction("GetProducts");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product product = _productServices.GetProductById(id);
            ViewBag.Providers = new SelectList(_providerServices.GetAllProviders(), "Id", "Name");

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            _productServices.EditProduct(product);

            return RedirectToAction("GetProducts");
        }

        public IActionResult Delete(int id)
        {
            _productServices.DeleteProduct(id);

            return RedirectToAction("GetProducts");
        }
    }
}