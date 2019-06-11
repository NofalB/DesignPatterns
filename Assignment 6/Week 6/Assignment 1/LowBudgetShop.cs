using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LowBudgetShop : ComputerShop
    {
        

        public override IMonitor MakeMonitor()
        {
            return new CheapMonitor(); 
        }

        public override IProcessor MakeProcessor()
        {
            return new CheapProcessor();
        }

        public override IHardDisk MakeHardDisk()
        {
            return new CheapHarddisk();
        }

        
    }
}
