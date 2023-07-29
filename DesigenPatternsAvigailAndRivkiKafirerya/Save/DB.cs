using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal class DB : StrategyAllOrders
    {
        public List<Order> FindOrder(string name, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Order> Loud()
        {
            throw new NotImplementedException();
        }

        public void SaveMe(Order orderToSave)
        {
            throw new NotImplementedException();
        }
    }
}
