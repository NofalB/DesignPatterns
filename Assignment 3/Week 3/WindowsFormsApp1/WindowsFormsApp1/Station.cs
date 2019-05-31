using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Station
    {
        public string name;
        public string arrivalTrack;
        private string arrivalTime;
        private string departureTime;

        public Station(string name, string arrivalTrack, string arrivalTime, string departureTime)
        {
            this.name = name;
            this.arrivalTrack = arrivalTrack;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
        }

    }
}
