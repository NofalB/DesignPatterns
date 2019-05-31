using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Airplane : IFlyable
    {
        void IFlyable.LiftOff()
        {
            Console.WriteLine("airplane is taking off...");
        }
        void IFlyable.Fly()
        {
            for (int x = 0; x < 3; x++)
                Console.WriteLine("airplane is flying...");
        }
        void IFlyable.Land()
        {
            Console.WriteLine("airplane is landing...");
        }
    }
}
