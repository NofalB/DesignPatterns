using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class PINPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Pin Payment...");
        }
    }
}
