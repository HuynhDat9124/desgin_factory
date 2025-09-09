using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    class WorkerA : RobotWorker
    {
        public override void Work()
        {
            Console.WriteLine("WorkerA is assembling cars.");
        }
    }
}
