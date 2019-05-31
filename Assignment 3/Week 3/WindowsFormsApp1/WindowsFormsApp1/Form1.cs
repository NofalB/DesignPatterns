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
    public partial class Form1 : Form
    {
        private TrainController controller;
        private ITrainJourney journey;

        public Form1()
        {
            InitializeComponent();

            journey = new TrainJourney();
            controller = new TrainController(journey);

            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.getNextStation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IObserver StationDisplay1 = new ITrainDisplay(journey);
            ((ITrainDisplay)StationDisplay1).Show();
        }
    }
}
