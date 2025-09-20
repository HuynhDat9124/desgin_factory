using System;

namespace DPM225412_HuynhTruongPhatDat_Pattern06_Adapter
{
    /// <summary>
    /// Adapter Design Pattern - Client
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
