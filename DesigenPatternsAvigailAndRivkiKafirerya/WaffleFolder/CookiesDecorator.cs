using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class CookiesDecorator : WaffleDecorators
    {
        public CookiesDecorator(Waffle waffle) : base(waffle)
        {
            Debug.WriteLine("CookiesDecorator");
        }
        public override double GetCost()
        {
            Debug.WriteLine("GetCost on CookiesDecorator");
            return waffle.GetCost() + 5;
        }
    }
}
