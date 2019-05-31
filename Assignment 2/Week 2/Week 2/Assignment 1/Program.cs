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
            CallDataLoader callLoader = new CallDataLoader();
            TwitterDataLoader twitterLoader = new TwitterDataLoader();
            SensorDataLoader sensorLoader = new SensorDataLoader();
            BatchProcessor processor = new BatchProcessor();

            processor.BatchLoader(callLoader);
            processor.BatchLoader(twitterLoader);
            processor.BatchLoader(sensorLoader);

            processor.BatchProcess();
           
        }
    }
}
