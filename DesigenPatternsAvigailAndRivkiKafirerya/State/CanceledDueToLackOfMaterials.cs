using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class CanceledDueToLackOfMaterials : OrderState
    {
        public CanceledDueToLackOfMaterials(Order myOrder) : base(myOrder)
        {
            Debug.WriteLine("CanceledDueToLackOfMaterials from CanceledDueToLackOfMaterials");
            StateString = "cancele";
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
            Debug.WriteLine("OrderTheOrderHasEnded from CanceledDueToLackOfMaterials");
            myOrder.ChangeState(new TheOrderHasEnded(myOrder));
        }


        public override void OrderTransferredToWaiter()
        {
            throw new NotImplementedException();
        }

    }
}
