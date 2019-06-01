using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LowBudgetShop : ComputerShop, IProcessor, IMonitor,IHardDisk
    {
        public override void AssembleMachine()
        {
            PerformOperation();
            StoreData();
            Display();

        }

        public void PerformOperation()
        {
            Console.WriteLine("performing operation not so quickly");

        }

        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly");
        }

        public void Display()
        {
            Console.WriteLine("displaying stuff very poor");
        }

    }
}
