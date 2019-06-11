using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface ITrainJourney
    {
        Station CurrentStation { get; }
        void NextStation();

        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
     //   void NotifyObserver();
        
    }
}
