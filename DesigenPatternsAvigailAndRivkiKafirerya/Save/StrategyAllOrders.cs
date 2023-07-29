using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal interface StrategyAllOrders
    {
        public List<Order> Loud();
        public void SaveMe(Order orderToSave);
        public List<Order> FindOrder(string name, DateTime date);

    }
}
