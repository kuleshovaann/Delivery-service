using System;
using System.Collections.Generic;
using Models.Models;

namespace Models.Contracts
{
    public interface ICompany
    {
        public string Name { get; set; }

        List<Dish> Menu { get; set; }
    }
}
