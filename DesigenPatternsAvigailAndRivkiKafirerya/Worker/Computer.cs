using DesigenPatternsAvigailAndRivkiKafirerya.Worker;
using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesigenPatternsAvigailAndRivkiKafirerya
{
    internal class Computer
    {
        public StrategyAllOrders Strategy { get; set; }
        List<Order> orders = new();
        public Computer(StrategyAllOrders strategy)
        {
            Debug.WriteLine("Computer");
            Strategy = strategy;
        }
        public void Raed()
        {
            Debug.WriteLine("Raed");
            orders = Strategy.Loud();
        }
        public void Save(Order orderToSave)
        {
            Debug.WriteLine("Save");
            Strategy.SaveMe(orderToSave);
        }
        public List<Order> FindOrders(string name, DateTime date)
        {
            Debug.WriteLine("FindOrders");
            List<Order> orders = Strategy.FindOrder(name, date);
            return orders;
        }


    }
}
