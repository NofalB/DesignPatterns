using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class BatchProcessor 
    {
        List<BigDataLoader> loader = new List<BigDataLoader>();

        public void BatchLoader(BigDataLoader dataload)
        {
            
                loader.Add(dataload);
            
        }

        public void BatchProcess()
        {
            foreach (BigDataLoader load in loader)
            {
                load.EtlProcess();
            }
        }
    }
}
