using System.Collections.Generic;
using System;

namespace Models.Models
{
    public class Company 
    {
        public Company()
        {
            Menu = new List<Dish>();
        }
        public string Name { get; set; }

        public List<Dish> Menu;
    }
}
