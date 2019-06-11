using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class PINPayment : Payment
    {
        public override void Execute()
        {
            Console.WriteLine("entering information...");
            Console.WriteLine("processing PIN payment...");
            Console.WriteLine("sending confirmation mail...");
        }
    }
}
