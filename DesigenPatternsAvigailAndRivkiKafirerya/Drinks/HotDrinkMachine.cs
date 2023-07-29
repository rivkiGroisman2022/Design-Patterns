using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal class HotDrinkMachine
    {
        public void Make(HotDrinkBuilder drink)
        {
            Debug.WriteLine("Make on HotDrinkMachine");
            drink.BoilingWater();
            drink.AddPowder();
            drink.WhippingMilk();
        }
    }
}
