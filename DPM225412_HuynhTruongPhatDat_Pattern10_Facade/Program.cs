using System;

namespace DPM225412_HuynhTruongPhatDat_Pattern10_Facade
{
    /// <summary>
    /// Facade Design Pattern - Client
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
