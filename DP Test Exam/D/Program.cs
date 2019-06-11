using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        public void Start()
        {
            // create solarpanel system
            IObservable systeem = new SolarPanelSystem();

            // create a controller
            // TODO...
            IPanelController panelController = new PanelController(systeem);


            // create a solarpanel display
            // TODO...
            IObserver solarDisplay = new SolarPanelDisplay(systeem);

            // perform a few measurements
            for (int i = 0; i < 10; i++)
            {
                panelController.NewMeasurement();
            }
            systeem.AddObserver(solarDisplay);



            Console.ReadKey();
        }
    }
}
