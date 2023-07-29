using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal interface IObserver
    {
        public void Ready(OrderReady order);
    }
}
