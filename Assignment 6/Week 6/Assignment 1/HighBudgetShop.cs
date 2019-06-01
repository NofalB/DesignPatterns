using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class HighBudgetShop : ComputerShop ,IProcessor, IHardDisk, IMonitor
    {
        public override void AssembleMachine()
        {
            PerformOperation();
            StoreData();
            Display();

        }

        public void PerformOperation()
        {
            Console.WriteLine("performing operation very quickly");

        }

        public void StoreData()
        {
            Console.WriteLine("storing data very quickly");
        }

        public void Display()
        {
            Console.WriteLine("displaying stuff very nice");
        }





    }
}
