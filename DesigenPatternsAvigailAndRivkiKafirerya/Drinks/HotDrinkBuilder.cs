using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal abstract class HotDrinkBuilder : Drink
    {
        public void BoilingWater()
        {
            Debug.WriteLine("BoilingWater on HotDrinkBuilder");
        }
        public void WhippingMilk()
        {
            Debug.WriteLine("WhippingMilk on HotDrinkBuilder");
        }
        public abstract void AddPowder();
    }
}
