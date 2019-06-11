using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            // ....
            Console.WriteLine("Copying with machine 1");

            CopyingMachine copyingMachine = CopyingMachine.GetMachine();
            copyingMachine.Copy(10);
            copyingMachine.Copy(23);

            Console.WriteLine();
            Console.WriteLine("Copying with machine 2");

            CopyingMachine copyingMachine1 = CopyingMachine.GetMachine();
            copyingMachine.Copy(40);
        }
    }
}
