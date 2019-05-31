using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Superman : IFlyable
    {
        void IFlyable.LiftOff()
        {
            Console.WriteLine("superman is taking off...");
        }
        void IFlyable.Fly()
        {
            for(int x=0;x<3; x++)
            Console.WriteLine("superman is flying around...");
        }
        void IFlyable.Land()
        {
            Console.WriteLine("superman is landing...");
        }
    }
}
