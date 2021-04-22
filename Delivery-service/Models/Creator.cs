using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string Address { get; set; }

        void Create() { }
        void Delete() { }
    }
}
