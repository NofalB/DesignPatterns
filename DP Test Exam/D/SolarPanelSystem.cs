using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class SolarPanelSystem : IObservable
    {
        List<IObserver> observers;
        Random random;
        public int Power { get; set; }
        public SolarPanelSystem()
        {
            observers = new List<IObserver>();
            random = new Random();
        }
        public int NewMeasurement()
        {
            return Power = random.Next(300,400);
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
            UpdateObserver();
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        private void UpdateObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }
}
