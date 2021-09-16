using System;

namespace DeliverySystem.DAL.Models
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Card { get; set; }
    }
}
