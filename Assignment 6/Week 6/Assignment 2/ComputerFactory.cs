﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    interface ComputerFactory 
    {
        IProcessor MakeProcessor();
        IHardDisk MakeHarddisk();
        IMonitor MakeDisplay();
        
    }
}
