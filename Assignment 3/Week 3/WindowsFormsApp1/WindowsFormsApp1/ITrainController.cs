using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ITrainController
    {
        //void CurrentStation();
        //void NextStation();
        void NextStation();
        Station getCurrentStation();


    }
}
