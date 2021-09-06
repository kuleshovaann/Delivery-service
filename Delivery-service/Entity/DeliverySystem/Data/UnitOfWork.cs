using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.DAL.Data
{
    public class UnitOfWork
    {
        private DataContext dataContext = new DataContext();
        private IRepository<Customer> _customerRepository;
        private IRepository<Delivery> _deliveryRepository;
        private IRepository<Order> _orderRepository;
        private IRepository<Product> _productRepository;
        private IRepository<Provider> _providerRepository;

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new Repository<Customer>(dataContext);
                return _customerRepository;
            }
        }

        public IRepository<Delivery> Deliveries
        {
            get
            {
                if (_deliveryRepository == null)
                    _deliveryRepository = new Repository<Delivery>(dataContext);
                return _deliveryRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new Repository<Order>(dataContext);
                return _orderRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new Repository<Product>(dataContext);
                return _productRepository;
            }
        }

        public IRepository<Provider> Providers
        {
            get
            {
                if (_providerRepository == null)
                    _providerRepository = new Repository<Provider>(dataContext);
                return _providerRepository;
            }
        }

        public void Save()
        {
            dataContext.SaveChanges();
        }
    }
}
