using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public abstract class ComputerFactory : ComputerShop
    {
        public abstract void MakeProcessor();
        public abstract void MakeHarddisk();
        public abstract void MakeDisplay();
        
    }
}
