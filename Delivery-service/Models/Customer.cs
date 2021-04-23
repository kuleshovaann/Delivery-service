using System;

namespace Models
{
    public class Customer : Creator
    {
        public Customer(string _name) : base(_name) { }
        public DateTime Birthday { get; set; }

        void ToOrder() { }

        void EditOrder() { }

        void CancelOrder() { }

        void RequestCall() { }

        void Pay() { }
    }
}
