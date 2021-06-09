using System.Collections.Generic;
using System;
using DeliveryService.Contracts;

namespace DeliveryService.Models
{
    public class Company
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
        public Company()
        {
            Dishes = new List<Dish>();
        }
    }
}
