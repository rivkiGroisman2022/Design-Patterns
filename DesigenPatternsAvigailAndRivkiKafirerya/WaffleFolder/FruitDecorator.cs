using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class FruitDecorator : WaffleDecorators
    {
        public FruitDecorator(Waffle waffle) : base(waffle)
        {
            Debug.WriteLine("FruitDecorator");
        }
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on FruitDecorator");
            return waffle.GetCost() + 5;
        }
    }
}
