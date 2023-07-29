using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal interface IInformer
    {
        public void Attach(IObserver observer);
        public void Detach(IObserver observer);
        public void Notify();
    }
}
