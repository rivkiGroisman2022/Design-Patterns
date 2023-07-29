using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class PekanDecorator : WaffleDecorators
    {
        public PekanDecorator(Waffle waffle) : base(waffle)
        {
            Debug.WriteLine("PekanDecorator");
        }
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on PekanDecorator");
            return waffle.GetCost() + 5;
        }
    }
}
