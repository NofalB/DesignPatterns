using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class ComputerShop 
    {
     

        public abstract IMonitor MakeMonitor();
        public abstract IProcessor MakeProcessor();
        public abstract IHardDisk MakeHardDisk();

        public void AssembleMachine()
        {
            IMonitor monitor = MakeMonitor();
            IProcessor processor = MakeProcessor();
            IHardDisk hardDisk = MakeHardDisk();

            monitor.Display();
            processor.PerformOperation();
            hardDisk.StoreData();
        }



    }
}
