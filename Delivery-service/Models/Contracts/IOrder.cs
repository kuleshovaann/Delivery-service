using System;
using Models.Models;
using System.Collections.Generic;

namespace Models.Contracts
{
    public interface IOrder
    {
        Customer Customer { get; set; }

        Company Company { get; set; }

        double FullPrice { get; set; }

        List<Dish> Titles { get; set; }
    }
}
