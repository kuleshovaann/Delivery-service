using System;
using System.Collections.Generic;

namespace DeliveryService.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public string Address { get; set; }
    }
}
