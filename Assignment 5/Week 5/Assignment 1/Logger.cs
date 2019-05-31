using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Logger
    {
        private int numberOfLines =1;
        private static Logger uniqueInstance;

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }
            return uniqueInstance;
        }

        public void Log(string type, string work)
        {
            Console.WriteLine("{0} - [{1}] {2}",numberOfLines, type, work);
            numberOfLines++;
        }
    }
}
