﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class  HighLife : ILifeBehaviour
    {
        public bool ChangeLife(bool livingCell, int neighbourCount)
        {
            // with 3 neighbour cell will live
            if (neighbourCount == 3 || neighbourCount == 6)
                return true;

            // live cell with 2 neighbours stays alive
            if (livingCell && neighbourCount == 2)
                return true;

            // dead cell
            return false;
        }
       
    }
}
