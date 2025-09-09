using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    class GuardB : RobotGuard
    {
        public override void Protect(RobotWorker worker)
        {
            Console.WriteLine("GuardB protects " + worker.GetType().Name);
        }
    }
}
