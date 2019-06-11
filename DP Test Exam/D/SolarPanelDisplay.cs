using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class SolarPanelDisplay : IObserver
    {
        private IObservable solarPanelSystem;
        public SolarPanelDisplay(IObservable solarPanelSystem)
        {
            this.solarPanelSystem = solarPanelSystem;
            solarPanelSystem.AddObserver(this); 
        }
        public void Update()
        {
            int power = solarPanelSystem.NewMeasurement();
            Console.WriteLine($"New Measurement: {power} Watt");
        }
    }
}
