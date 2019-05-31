using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TrainJourney : ITrainJourney
    {
        List<Station> stationList = new List<Station>();
        private List<IObserver> observerList = new List<IObserver>();

        public Station currentStation { get; private set; }
        public Station nextStation { get; private set; }

        int index = 0;


        public Station CurrentStation
        {
            get
            {
                return currentStation = stationList.ElementAt(index);
            }
        }

        public void NextStation()
        {
            Station nextStation = stationList.ElementAt(++index);

            NotifyObserver();

        }



        public void AddStations()
        {
            Station station1 = new Station("Hello", "den helder", "13:40", "14:00");
            Station station2 = new Station("Hell", "Breda", "16:40", "17:00");
            Station station3 = new Station("He", "Bryan", "16:40", "17:00");

            stationList.Add(station1);
            stationList.Add(station2);
            stationList.Add(station3);
        }

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (IObserver observers in observerList)
            {
                observers.Update(currentStation);
            }
        }




    }
}
