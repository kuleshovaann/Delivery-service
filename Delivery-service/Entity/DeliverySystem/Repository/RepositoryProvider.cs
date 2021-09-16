using Dapper;
using DeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DeliverySystem.Repository
{
    public class RepositoryProvider : IRepository
    {
        private IDbConnection dbConnection;

        public RepositoryProvider(string connectionString)
        {
            dbConnection = new SqlConnection(connectionString);
        }

        public void AddProvider(Provider provider)
        {
            var sql = "insert into [dbo].[Provider] ([Name]) values @name";
            dbConnection.Query<Provider>(sql, provider);
        }

        public void DeleteProvider(int id)
        {
            var sql = "delete from [dbo].[Provider] where Id = @Id";
            dbConnection.Query<Provider>(sql, new { Id = id });
        }

        public List<Provider> GetCProviders()
        {
            var sql = "select * from [dbo].[Provider]";
            return dbConnection.Query<Provider>(sql).ToList();
        }

        public Provider GetProviderById(int id)
        {
            var sql = "SELECT * FROM [dbo].[Provider] where Id = @Id";
            return dbConnection.Query<Provider>(sql, new { Id = id }).SingleOrDefault();
        }

        public void UpdateProvider(string newName, int id)
        {
            var sql = "update [dbo].[Provider] set name = @name where id = @id";
            dbConnection.Query<Provider>(sql, new { name = newName, id = id });
        }
    }
}
