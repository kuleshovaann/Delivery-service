using DeliverySystem.DAL.Contracts;
using DeliverySystem.DAL.Models;
using DeliverySystem.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliverySystem.DAL.Data
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public T Create(T item)
        {
            _dataContext.Add(item);
            _dataContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var item = _dataContext.Set<T>().FirstOrDefault(m => m.Id == id);
            if (item != null)
                _dataContext.Set<T>().Remove(item);
            _dataContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dataContext.Set<T>().FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataContext.Set<T>();
        }

        public T Update(T item)
        {
            _dataContext.Update(item);
            _dataContext.SaveChanges();
            return item;
        }
    }
}
