using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HighBudgetFactory :ComputerFactory,IProcessor,IHardDisk,IMonitor
    {
        
        
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
    }
}
