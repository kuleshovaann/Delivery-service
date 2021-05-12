﻿using System;
using Models.Contracts;
using System.Collections.Generic;

namespace Models.Models
{
    public class Order : IOrder
    {
        public Order()
        {
            Titles = new List<Dish>();
        }
        public Customer Customer { get; set; }

        public Company Company { get; set; }

        public double FullPrice { get; set; }

        public List<Dish> Titles { get; set; }
    }
}
