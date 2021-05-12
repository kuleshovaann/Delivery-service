using System;
using Models.Models;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface IOrder
    {
        public Customer Customer { get; set; }

        public Company Company { get; set; }

        public double FullPrice { get; set; }

        public List<Dish> Titles { get; set; }
    }
}
