using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_service.Models
{
    class Order
    {
        public int NumberOfOrder { get; set; }
        public string Status { get; set; }

        public Customer _customer;

        public Company Company;

        public Menu[] _menu;

        public double FullPrice { get; set; }

        public double FullPriceWithDiscount { get; set; }
    }
}
