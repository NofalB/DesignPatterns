using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class ComputerShop 
    {
        public virtual void AssembleMachine() { return; }

        public ComputerShop CreateShop(string x)
        {
            if (x == "High")
                return new HighBudgetShop();
            else if (x == "Low")
                return new LowBudgetShop();
            else
                return null;

        }

    }
}
