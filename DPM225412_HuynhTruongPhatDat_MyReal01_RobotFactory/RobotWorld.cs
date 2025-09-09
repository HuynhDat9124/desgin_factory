using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_MyReal01_RobotFactory
{
    class RobotWorld
    {
        private RobotWorker _worker;
        private RobotGuard _guard;

        public RobotWorld(RobotFactory factory)
        {
            _worker = factory.CreateWorker();
            _guard = factory.CreateGuard();
        }

        public void RunScenario()
        {
            _worker.Work();
            _guard.Protect(_worker);
        }
    }
}

