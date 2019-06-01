using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");

            ComputerFactory cheapComputerFactory = new HighBudgetFactory();
            ComputerShop computerShop1 = new ComputerShop();

            computerShop1.AssembleMachine(cheapComputerFactory);

            Console.WriteLine();
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory expnsiveComputerFactory = new LowBudgetFactory();
            ComputerShop computerShop2 = new ComputerShop();
            computerShop2.AssembleMachine(expnsiveComputerFactory);
            Console.ReadKey();
        }
    }
}
