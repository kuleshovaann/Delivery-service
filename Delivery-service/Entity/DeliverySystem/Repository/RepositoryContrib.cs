using Dapper.Contrib.Extensions;
using DeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DeliverySystem.Repository
{
    class RepositoryContrib : IRepository
    {
        private IDbConnection dbConnection;

        public RepositoryContrib(string connectionString)
        {
            dbConnection = new SqlConnection(connectionString);
        }

        public void AddProvider(Provider provider)
        {
            dbConnection.Insert<Provider>(provider);
        }

        public void DeleteProvider(int id)
        {
            dbConnection.Delete(new Provider { Id = id });
        }

        public List<Provider> GetCProviders()
        {
            return dbConnection.GetAll<Provider>().ToList();
        }

        public Provider GetProviderById(int id)
        {
            return dbConnection.Get<Provider>(id);
        }

        public void UpdateProvider(string newName, int id)
        {
            var provider = GetProviderById(id);
            provider.Name = newName;
            dbConnection.Update(provider);
        }
    }
}
