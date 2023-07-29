using DesigenPatternsAvigailAndRivkiKafirerya.Drinks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class ColdDrinkMachine
    {
        public void Make(ColdDrinkBuilder drink)
        {
            Debug.WriteLine("Make on ColdDrinkMachine");
            drink.PouringDrink();
            drink.AddsIce();
        }



    }
}
