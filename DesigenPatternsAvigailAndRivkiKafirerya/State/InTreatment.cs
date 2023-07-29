using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class InTreatment : OrderState
    {
        public InTreatment(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("InTreatment from InTreatment");
            StateString = "in treatment";
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
            Debug.WriteLine("OrderTheOrderHasBeenPlaced from InTreatment");
            myOrder.ChangeState(new TheOrderHasBeenPlaced(myOrder));
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
