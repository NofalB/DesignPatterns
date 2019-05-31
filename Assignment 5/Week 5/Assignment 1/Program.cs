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
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            MainSystem MainSys = new MainSystem();
            Logger logger = Logger.GetInstance();
            logger.Log("main", "starting");
            MainSys.DoSomeMainWork();
            logger.Log("main", "finishing");
        }
    }
}
