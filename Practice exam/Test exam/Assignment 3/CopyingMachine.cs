using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class CopyingMachine
    {
        private int totalNumberOfCopies;
        private static CopyingMachine uniqueInstance;

        public void TotalNumberOfCopies(int TotalNumberOfCopies)
        {
            this.totalNumberOfCopies = TotalNumberOfCopies;
        }

        public void Copy()
        {

        }

        private CopyingMachine()
        {

        }

        public static CopyingMachine GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new CopyingMachine();

            return uniqueInstance;
        }
    }
}
