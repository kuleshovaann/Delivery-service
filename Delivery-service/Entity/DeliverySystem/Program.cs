using System;
using DeliverySystem.DAL.Services;
using DeliverySystem.DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DeliverySystem.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var creator = new DataCreator(unitOfWork);

            Console.ReadKey();
        }
    }
}
