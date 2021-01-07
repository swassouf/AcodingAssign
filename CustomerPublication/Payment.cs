using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPublication
{
   public class Payment
    {

       public string FirstName { get; set; }
       public string MiddleName { get; set; }
       public string LastName { get; set; }
       public string AccountNumber { get; set; }
       public int ExpirationMonth { get; set; }
       public int ExpirationYear { get; set; }
       public string Cvv  { get; set; }

       private BillingAddress BillingAddress { get; set; }

    }
}
