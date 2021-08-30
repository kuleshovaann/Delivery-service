using DeliverySystem.Contracts;
using DeliverySystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DeliverySystem.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DataContext _dataContext;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(T item)
        {
            _dataContext.Set<T>().Add(item);
        }

        public void Delete(int id)
        {
            T item = _dataContext.Set<T>().Find(id);
            if (item != null)
                _dataContext.Set<T>().Remove(item);
        }

        public T Get(int id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dataContext.Set<T>();
        }

        public void Update(T item)
        {
            _dataContext.Entry(item).State = EntityState.Modified;
        }
    }
}
