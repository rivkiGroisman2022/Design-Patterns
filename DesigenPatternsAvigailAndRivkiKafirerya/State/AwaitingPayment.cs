using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class AwaitingPayment : OrderState
    {
        public AwaitingPayment(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("AwaitingPayment from AwaitingPayment");
            StateString = "wait payment ";
        }

        public override void OrderAtTheCustomer()
        {
            Debug.WriteLine("OrderAtTheCustomer from AwaitingPayment");
            myOrder.ChangeState(new AtTheCustomer(myOrder));
        }

        public override void OrderAwaitingPayment()
        {
            throw new NotImplementedException();
        }

        public override void OrderCanceledDueToLackOfMaterials()
        {
            throw new NotImplementedException();
        }

        public override void OrderInTreatment()
        {
            throw new NotImplementedException();
        }

        public override void OrderMovedToTheKitchen()
        {
            throw new NotImplementedException();
        }

        public override void OrderTheOrderHasBeenPlaced()
        {
            throw new NotImplementedException();
        }

        public override void OrderTheOrderHasEnded()
        {
            myOrder.ChangeState(new TheOrderHasEnded(myOrder));
        }

        public override void OrderTransferredToWaiter()
        {
            throw new NotImplementedException();
        }
    }
}
