using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_Pattern11_Flyweight
{
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}
