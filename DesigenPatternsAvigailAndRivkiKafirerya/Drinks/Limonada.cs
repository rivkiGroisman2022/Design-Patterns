using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal class Limonada : ColdDrinkBuilder
    {
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on Limonada");
            return 12;
        }
        public override void PouringDrink()
        {
            Debug.WriteLine("PouringDrink on Limonada");
        }
    }
}
