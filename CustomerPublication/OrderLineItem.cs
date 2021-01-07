using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPublication
{
  public  class OrderLineItem
    {
        public OrderLine OrderLine { get; set; }
        public int Quantity { get; set; }
    }
}
