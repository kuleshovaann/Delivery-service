using DeliverySystem.DAL.Data;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Contracts;
using System;
using System.Collections.Generic;


namespace DeliverySystem.DAL.Services
{
    public class ProductServices : IProductServices
    {
        private UnitOfWork _unitOfWork;

        public ProductServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _unitOfWork.Products.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _unitOfWork.Products.Get(id);
        }

        public void CreateProduct(Product product)
        {
            _unitOfWork.Products.Create(product);
        }

        public Product EditProduct(Product product)
        {
            return _unitOfWork.Products.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _unitOfWork.Products.Delete(id);
        }
    }
}
