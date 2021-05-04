using System;
using Models.Contracts;

namespace Models.Models
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string Address { get; set; }
    }
}
