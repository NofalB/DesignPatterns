using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class PanelController : IPanelController
    {
        private IObservable solarPanel;
        public PanelController(IObservable solarPanel)
        {
            this.solarPanel = solarPanel;
        }

        public void NewMeasurement()
        {
            solarPanel.NewMeasurement();
        }
    }
}
