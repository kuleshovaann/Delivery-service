using DeliverySystem.DAL.Models;
using System;
using System.Collections.Generic;

namespace DeliverySystem.DAL.Contracts
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Create(T item);
        T Update(T item);
        void Delete(int id);
    }
}
