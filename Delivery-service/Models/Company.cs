using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company : Creator
    {
        public string BankAccount { get; set; }
        public double Rating { get; set; }

        public Menu[] _menu;
        void AddMenu() { }
        void CancelMenu() { }
    }
}
