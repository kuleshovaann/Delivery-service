using System.Collections.Generic;
using System;
using Models.Contracts;

namespace Models.Models
{
    public class Company : ICompany
    {
        public Company()
        {
            Dishes = new List<Dish>();
        }
        public string Name { get; set; }

        public List<Dish> Dishes { get; set; }
    }
}
