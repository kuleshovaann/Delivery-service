﻿using System;
using DeliverySystem.Services;
using DeliverySystem.DataBase;
using DeliverySystem.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DeliverySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataContext();
            //-data.Database.Migrate();
            var providerDataBase = new ProviderDataBase();
            var productDataBase = new ProductDataBase();
            var creator = new DataCreator(providerDataBase, productDataBase);
            var linq = new LinqRequests(providerDataBase, productDataBase);

            Console.ReadKey();
        }      
    }
}
