using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class TheOrderHasBeenPlaced : OrderState
    {
        public TheOrderHasBeenPlaced(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("TheOrderHasBeenPlaced from TheOrderHasBeenPlaced");
            StateString = "ready";
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
            throw new NotImplementedException();
        }

        public override void OrderTransferredToWaiter()
        {
            Debug.WriteLine("OrderTransferredToWaiter from TheOrderHasBeenPlaced");
            myOrder.ChangeState(new TransferredToWaiter(myOrder));
        }
    }
}
