using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_Real05_Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class LoadBalancer
    {
        private static LoadBalancer instance;
        private List<string> servers = new List<string>();
        private Random random = new Random();

        // Lock synchronization object
        private static readonly object locker = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Double-checked locking for thread safety
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
            return instance;
        }

        // Simple random load balancer
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}
