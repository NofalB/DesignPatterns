using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class HighBudgetShop : ComputerShop
    {
        
        public override IMonitor MakeMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IProcessor MakeProcessor()
        {
            return new ExpensiveProcessor();
        }

        public override IHardDisk MakeHardDisk()
        {
            return new ExpensiveHarddisk();
        }
        
    }
}
