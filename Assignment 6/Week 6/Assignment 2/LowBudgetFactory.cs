using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class LowBudgetFactory : ComputerFactory
    {
        
        public IMonitor MakeDisplay()
        {
            return new CheapMonitor();
        }

        public IHardDisk MakeHarddisk()
        {
            return new CheapHarddisk();
        }

        public IProcessor MakeProcessor()
        {
            return new CheapProcessor();
        }
    }
}
