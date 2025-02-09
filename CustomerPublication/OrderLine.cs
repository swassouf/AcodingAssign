﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPublication
{
    public class OrderLine
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string UOM { get; set; }

        public bool IsPaymentCodeApplied { get; set; }
        public string PaymentDiscountCode { get; set; }

    }
}
