using System;
using System.Collections.Generic;
using Models.Models;

namespace Models.Contracts
{
    public interface ICompany
    {
        string Name { get; set; }

        List<Dish> Menu { get; set; }
    }
}
