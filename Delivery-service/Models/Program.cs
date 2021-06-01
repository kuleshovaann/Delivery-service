using System;
using Models.Models;
using Models.Services;


namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            company.Dishes.Add(new Dish() { Name = "Coffee", Price = 40.0, Сomposition = "Instant coffee", Weight = 90, Calories = 1});
            company.Dishes.Add(new Dish() { Name = "Black tea", Price = 30.0, Сomposition = "Ceylon long leaf tea", Weight = 200, Calories = 0});
            company.Dishes.Add(new Dish() { Name = "Green tea", Price = 30.0, Сomposition = "Green tea leaves", Weight = 200, Calories = 0});
            Console.Clear();

            var customer = new Customer();
            var starter = new Starter();

            starter.Start(company, customer);           
        }
    }
}
