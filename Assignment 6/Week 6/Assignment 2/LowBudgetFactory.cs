using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class LowBudgetFactory : ComputerFactory,IProcessor,IHardDisk,IMonitor
    {

        public override void MakeProcessor()
        {
            PerformOperation();
        }

        public override void MakeHarddisk()
        {
            StoreData();
        }

        public override void MakeDisplay()
        {
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
