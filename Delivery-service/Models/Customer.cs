﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer : Creator
    {
        public DateTime Birthday { get; set; }

        void ToOrder() { }

        void EditOrder() { }

        void CancelOrder() { }

        void RequestCall() { }

        void Pay() { }
    }
}
