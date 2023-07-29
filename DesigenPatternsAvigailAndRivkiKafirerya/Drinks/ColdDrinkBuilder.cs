using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal abstract class ColdDrinkBuilder : Drink
    {
        public abstract void PouringDrink();
        public void AddsIce()
        {
            Debug.WriteLine("AddsIce on ColdDrinkBuilder");

        }

    }
}
