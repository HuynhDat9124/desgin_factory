using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225412_HuynhTruongPhatDat_Real04_Prototype
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
