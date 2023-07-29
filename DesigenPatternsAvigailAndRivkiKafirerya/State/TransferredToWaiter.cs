using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class TransferredToWaiter : OrderState
    {
        public TransferredToWaiter(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("TransferredToWaiter from TransferredToWaiter");
            StateString = "Transferred To Waiter";
        }

        public override void OrderAtTheCustomer()
        {
            throw new NotImplementedException();
        }

        public override void OrderAwaitingPayment()
        {
            Debug.WriteLine("OrderAwaitingPayment from TransferredToWaiter");
            myOrder.ChangeState(new AwaitingPayment(myOrder));
        }


        public override void OrderCanceledDueToLackOfMaterials()
        {
            Debug.WriteLine("OrderCanceledDueToLackOfMaterials from TransferredToWaiter");
            myOrder.ChangeState(new CanceledDueToLackOfMaterials(myOrder));

        }

        public override void OrderInTreatment()
        {
            throw new NotImplementedException();
        }

        public override void OrderMovedToTheKitchen()
        {
            myOrder.ChangeState(new MovedToTheKitchen(myOrder));
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
            throw new NotImplementedException();
        }
    }
}
