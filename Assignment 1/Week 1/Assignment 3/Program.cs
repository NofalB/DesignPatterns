using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            IPencil p = new Pencil();
            IPencilSharpener ps = new PencilSharpener(); 

            Console.Write("Enter a sentence: ");
            string s = Console.ReadLine();

            while (s != "stop")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                p.Write(s);
                Console.ResetColor();

                Console.Write("Enter a sentence: ");
                s = Console.ReadLine();

                if(s== "sharpen")
                {
                    
                    ps.Sharpen(p);
                }
            }
        }
    }
}
