using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal class OrangeJuice : ColdDrinkBuilder
    {
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on OrangeJuice");
            return 10;
        }
        public override void PouringDrink()
        {
            Debug.WriteLine("PouringDrink on OrangeJuice");
        }
    }
}
