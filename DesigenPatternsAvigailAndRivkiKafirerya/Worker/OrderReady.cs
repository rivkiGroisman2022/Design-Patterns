using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsAvigailAndRivkiCafiterya;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal class OrderReady
    {
        public List<Product> MyproductsReady { get; set; }
        public Order order { get; set; }
        public OrderReady(Order order, List<Product> p)
        {
            Debug.WriteLine("OrderReady OrderReady");
            MyproductsReady = p;
            this.order = order;
        }
    }
}
