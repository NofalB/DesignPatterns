using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    abstract class Payment
    {
        public void EnterInfo()
        {
            Console.WriteLine("Entering information...");
        }
     
        public abstract void ProcessPayment();
        public void SendConfirm()
        {
            Console.WriteLine("Sending Confirmation mail");
        }
        public void Execute()
        {
            EnterInfo();
            ProcessPayment();
            SendConfirm();

        }
    }
}
