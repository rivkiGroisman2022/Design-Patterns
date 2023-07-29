using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class SquareWaffle : Waffle
    {
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on SquareWaffle");
            return 25;
        }
    }
}
