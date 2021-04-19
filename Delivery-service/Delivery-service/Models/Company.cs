using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_service.Models
{
    class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string[] PhoneNumbers { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

        public Menu[] _menu;

        void AddMenu() { }
    }
}
