using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal class coffee : HotDrinkBuilder
    {
        public override void AddPowder()
        {
            Debug.WriteLine("AddPowder on coffee");
        }

        public override double GetCost()
        {
            Debug.WriteLine("GetCost on coffee");
            return 20;
        }

    }
}
