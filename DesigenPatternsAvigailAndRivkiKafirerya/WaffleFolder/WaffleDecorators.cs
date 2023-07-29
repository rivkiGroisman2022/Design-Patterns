using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal abstract class WaffleDecorators : Waffle
    {
        protected Waffle waffle;
        public WaffleDecorators(Waffle waffle)
        {
            Debug.WriteLine("WaffleDecorators");
            this.waffle = waffle;
        }
    }
}
