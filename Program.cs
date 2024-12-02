using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Robot robot = new Robot("ロボット");
            Console.WriteLine("名前：{0}", robot.GetName());
            robot.Attack();


            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");
            Console.WriteLine("名前:{0}",flyingRobot.GetName());
            flyingRobot.Attack();

            TankRobot tankRobot = new TankRobot("タンクロボ");
            Console.WriteLine("名前:{0}",tankRobot.GetName());
            tankRobot.Attack();
            //FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボ");

            //Console.WriteLine("名前：{0}",flyingRobot.GetName());
            //Console.WriteLine("電源：{0}",flyingRobot.GetPowerStatus());
            
            //flyingRobot.DropBomb();
            //flyingRobot.PowerOn();
            //flyingRobot.DropBomb();

            //flyingRobot.PowerOff();

            //Console.WriteLine("-------");

            //TankRobot tankRobot = new TankRobot("タンクロボ");

            //Console.WriteLine("名前：{0}",tankRobot.GetName());
            //Console.WriteLine("電源：{0}",tankRobot.GetPowerStatus().ToString());

            //tankRobot.ShotCanon();
            //tankRobot.PowerOn();
            //tankRobot.ShotCanon();

            //tankRobot.PowerOff();

            //Console.WriteLine("-------");


            //TankRobot[] tanks = new TankRobot[5];

            //for (int i = 0; i < tanks.Length; i++)
            //{
            //    tanks[i] = new TankRobot("タンクNo" + i);
            //}

            //for (int i = 0; i < tanks.Length; i++)
            //{
            //    tanks[i].PowerOn();
            //}

            //foreach (TankRobot tank in tanks)
            //{
            //    tank.ShotCanon();
            //}

            Console.ReadLine();

        }
    }
}
