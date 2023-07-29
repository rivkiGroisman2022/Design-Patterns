using DesigenPatternsAvigailAndRivkiKafirerya;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal abstract class OrderState
    {
        public string StateString { get; set; }
        protected Order myOrder;
        public Order MyOrder
        {
            get { return myOrder; }
            set { myOrder = value; }
        }
        public OrderState(Order myOrder)
        {
            Debug.WriteLine("OrderState ctor");
            StateString = "Hi";
            MyOrder = myOrder;
        }
        public abstract void OrderAtTheCustomer();
        public abstract void OrderTransferredToWaiter();
        public abstract void OrderMovedToTheKitchen();
        public abstract void OrderCanceledDueToLackOfMaterials();
        public abstract void OrderInTreatment();
        public abstract void OrderTheOrderHasBeenPlaced();
        public abstract void OrderAwaitingPayment();
        public abstract void OrderTheOrderHasEnded();

    }
}
