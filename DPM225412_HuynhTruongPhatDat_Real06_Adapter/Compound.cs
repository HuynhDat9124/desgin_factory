using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_Real06_Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}
