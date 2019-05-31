using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ITrainDisplay : Form,IObserver
    {
        public ITrainDisplay(ITrainJourney journey)
        {
            InitializeComponent();
            journey.AddObserver(this);
        }

        public void Update(Station station)
        {
            label1.Text = station.name;

            label2.Text = station.arrivalTrack;
        }

        private void ITrainDisplay_Load(object sender, EventArgs e)
        {

        }

    }
}
