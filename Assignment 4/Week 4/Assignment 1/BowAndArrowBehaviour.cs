using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BowAndArrowBehaviour: IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shhoting an arrow with a bow");
        }
    }
}
