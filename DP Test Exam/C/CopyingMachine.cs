using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class CopyingMachine
    {
        int totalNumberOfCopies;
        private static CopyingMachine copyingMachine;
        public int TotalNumberOfCopies
        {
            get { return totalNumberOfCopies; }
            set { totalNumberOfCopies = value; }
        }
        private  CopyingMachine( )
        {
        }
        public static CopyingMachine GetMachine( )
        {
            if (copyingMachine == null)
            {
                copyingMachine = new CopyingMachine();
            }
            return copyingMachine;
        }
        public void Copy(int number)
        {
            Console.WriteLine($"Copying {number}x");
            totalNumberOfCopies += number;

            Console.WriteLine($"Total = {totalNumberOfCopies}x");
        }
    }
}
