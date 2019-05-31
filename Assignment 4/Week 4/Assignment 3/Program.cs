using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a tank (and assign it to a driver)
            Tank tank = new Tank("Frank");
            tank.AssignDriver();
            
            // create a robot (and let it move by a person)
            Robot robot = new Robot("Mark");
            robot.MoveByPerson();
            Console.WriteLine();
            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(new Adapter(robot));

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine();
                attacker.DriveForward();
                
                attacker.UseWeapon();
            }
        }
    }
}
