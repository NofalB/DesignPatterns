using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Adapter : IAttacker
    {
        private Robot robot;

        public Adapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver()
        {
            robot.MoveByPerson();
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
