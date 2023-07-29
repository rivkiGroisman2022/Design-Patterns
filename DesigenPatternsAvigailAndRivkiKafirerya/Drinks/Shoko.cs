using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Drinks
{
    internal class Shoko : HotDrinkBuilder
    {
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on Shoko");
            return 10;
        }
        public override void AddPowder()
        {
            Debug.WriteLine("AddPowder on Shoko");
        }
    }
}
