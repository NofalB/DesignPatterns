using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class SensorDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("Extracting sensor data...");

        }
        public override void Transform()
        {
            Console.WriteLine("Transforming snesor data...");
        }
        public override void Load()
        {
            Console.WriteLine("Loading sensor data...");
        }
    }
}
