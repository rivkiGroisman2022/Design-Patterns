using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class AtTheCustomer : OrderState
    {
        public AtTheCustomer(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("AtTheCustomer from AtTheCustomer");
            StateString = "At the client";
        }

        public override void OrderAtTheCustomer()
        {
            throw new NotImplementedException();
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
            Debug.WriteLine("OrderTheOrderHasEnded from AtTheCustomer");
            myOrder.ChangeState(new TheOrderHasEnded(myOrder));
        }

        public override void OrderTransferredToWaiter()

        {
            Debug.WriteLine("OrderTransferredToWaiter from AtTheCustomer");
            myOrder.ChangeState(new TransferredToWaiter(myOrder));
        }
    }
}
