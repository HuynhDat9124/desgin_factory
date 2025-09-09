using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    abstract class RobotFactory
    {
        public abstract RobotWorker CreateWorker();
        public abstract RobotGuard CreateGuard();
    }
}
