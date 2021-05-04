using System.Collections.Generic;
using System;
using Models.Contracts;

namespace Models.Models
{
    public class Company : ICompany
    {
        public Company()
        {
            Menu = new List<Dish>();
        }
        public string Name { get; set; }

        public List<Dish> Menu { get; set; }
    }
}
