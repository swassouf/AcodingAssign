using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPublication
{
    [Serializable]
    public class Publication
    {
        public int UserLoginId { get; set; }
        public string UserName { get; set; }
        public Shipping Shipping { get; set; }
        public Payment Payment { get; set; }
        public List<OrderLineItem> OrderLineItems { get; set; }

    }
}
