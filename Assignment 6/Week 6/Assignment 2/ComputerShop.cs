using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class ComputerShop 
    {
        //implement this correctly!

        ComputerFactory computerFactory;

        public ComputerShop(ComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }


        public void AssembleMachine()
        {
            IMonitor monitor = computerFactory.MakeMonitor();
            IProcessor processor = MakeProcessor();
            IHardDisk hardDisk = MakeHardDisk();

            monitor.Display();
            processor.PerformOperation();
            hardDisk.StoreData();
        }

    }
}
