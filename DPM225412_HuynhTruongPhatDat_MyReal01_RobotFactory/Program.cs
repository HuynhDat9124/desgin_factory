using DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory;
using System;

namespace MyReal02
{
    class Program
    {
        static void Main(string[] args)
        {

            RobotFactory japan = new JapanFactory();
            RobotWorld world1 = new RobotWorld(japan);
            world1.RunScenario();


            RobotFactory usa = new USFactory();
            RobotWorld world2 = new RobotWorld(usa);
            world2.RunScenario();

            Console.ReadKey();
        }
    }
}