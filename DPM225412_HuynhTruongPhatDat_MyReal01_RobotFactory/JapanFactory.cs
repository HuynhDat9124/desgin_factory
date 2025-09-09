using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    class JapanFactory : RobotFactory
    {
        public override RobotWorker CreateWorker()
        {
            return new WorkerA();
        }

        public override RobotGuard CreateGuard()
        {
            return new GuardA();
        }
    }
}
