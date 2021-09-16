using DeliverySystem.DAL.Models;
using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Contracts
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        Product EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
