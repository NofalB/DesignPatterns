using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public interface ILifeBehaviour
    {
        bool ChangeLife(bool livingCell, int neighBourCount);
    }
}
