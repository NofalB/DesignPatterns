using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class MainSystem
    {

        SubSystem subSystem;
        Logger logger;

        public MainSystem()
        {
            subSystem = new SubSystem();
            logger = Logger.GetInstance();

        }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }

        
    }
}
