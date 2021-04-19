using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_service.Models
{
    class Customer : User
    {
        public DateTime BDay { get; set; }

        void ToOrder() { }

        void EditOrder() { }

        void CancelOrder() { }

        void RequestCall() { }

        void Pay() { }
    }
}
