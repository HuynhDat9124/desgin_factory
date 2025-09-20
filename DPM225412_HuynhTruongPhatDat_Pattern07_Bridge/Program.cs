using System;

namespace DPM225412_HuynhTruongPhatDat_Pattern07_Bridge
{
    /// <summary>
    /// Bridge Design Pattern - Structural Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implementation and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
