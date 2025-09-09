using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    class USFactory : RobotFactory
    {
        public override RobotWorker CreateWorker()
        {
            return new WorkerB();
        }

        public override RobotGuard CreateGuard()
        {
            return new GuardB();
        }
    }
}
