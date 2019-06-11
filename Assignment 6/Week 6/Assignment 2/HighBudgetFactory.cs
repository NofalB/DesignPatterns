using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HighBudgetFactory :ComputerFactory
    {
        public IMonitor MakeDisplay()
        {
            return new ExpensiveMonitor();
        }

        public IHardDisk MakeHarddisk()
        {
            return new ExpensiveHarddisk();
        }

        public IProcessor MakeProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
