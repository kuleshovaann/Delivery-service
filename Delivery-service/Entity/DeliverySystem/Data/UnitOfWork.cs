using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Services;
using System;
using System.Linq;

namespace DeliverySystem.DAL.Data
{
    public class UnitOfWork
    {
        private DataContext _dataContext;
        private IRepository<Customer> _customerRepository;
        private IRepository<Delivery> _deliveryRepository;
        private IRepository<Order> _orderRepository;
        private IRepository<Product> _productRepository;
        private IRepository<Provider> _providerRepository;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            var creator = new DataCreator(this);

            if (!_dataContext.Products.Any())
            {
                creator.CreateData();
            }
        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new Repository<Customer>(_dataContext);
                return _customerRepository;
            }
        }

        public IRepository<Delivery> Deliveries
        {
            get
            {
                if (_deliveryRepository == null)
                    _deliveryRepository = new Repository<Delivery>(_dataContext);
                return _deliveryRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new Repository<Order>(_dataContext);
                return _orderRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new Repository<Product>(_dataContext);
                return _productRepository;
            }
        }

        public IRepository<Provider> Providers
        {
            get
            {
                if (_providerRepository == null)
                    _providerRepository = new Repository<Provider>(_dataContext);
                return _providerRepository;
            }
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
