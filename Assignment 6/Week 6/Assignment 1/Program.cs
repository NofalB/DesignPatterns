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
            ComputerShop shop = new HighBudgetShop();
            

            Console.WriteLine("[shop creating expensive computers]");
            
            shop.AssembleMachine();
           
            Console.WriteLine();

            // create a shop where they assemble cheap computers
            ComputerShop shop2 = new LowBudgetShop();
            Console.WriteLine("[shop creating cheap computers]");
            // ... create shop
            shop2.AssembleMachine();

            Console.ReadKey();
        }
    }
}
