using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class MovedToTheKitchen : OrderState
    {
        public MovedToTheKitchen(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("MovedToTheKitchen from MovedToTheKitchen");
            StateString = "Moved To TheKitchen";
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
            Debug.WriteLine("OrderInTreatment from MovedToTheKitchen");
            myOrder.ChangeState(new InTreatment(myOrder));
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
            throw new NotImplementedException();
        }
    }
}
