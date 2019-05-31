using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Robot
    {
        private string generator;

        public Robot(string generator)
        {
            this.generator = generator;
        }

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public void MoveByPerson()
        {
            Console.WriteLine("Robot is moved by {0}", generator);   
        }

        public void WalkForward()
        {
            Console.WriteLine("Robot walks 3 steps forward");
        }
    }
}
