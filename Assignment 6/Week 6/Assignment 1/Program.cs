using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerShop shop = new ComputerShop();

            Console.WriteLine("[shop creating expensive computers]");
            shop = shop.CreateShop("High");
            shop.AssembleMachine();
           
            Console.WriteLine();

            // create a shop where they assemble cheap computers

            Console.WriteLine("[shop creating cheap computers]");
            // ... create shop
            shop = shop.CreateShop("Low");
            shop.AssembleMachine();

            Console.ReadKey();
        }
    }
}
