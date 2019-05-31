using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Tank : IAttacker
    {
        string generator;

        public Tank(string generator)
        {
            this.generator = generator;
        }
        
        public void AssignDriver()
        {
            Console.WriteLine("{0} is steering the tank", generator);
        }

        public void DriveForward()
        {
            Console.WriteLine("Tank moves 3 positions forward");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage");
        }

    }
}
