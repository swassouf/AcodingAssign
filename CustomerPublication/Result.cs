using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPublication
{
   public class Result<T>
    {
        public  string Message { get; set; }

        public T Model { get; set; }
    }
}
