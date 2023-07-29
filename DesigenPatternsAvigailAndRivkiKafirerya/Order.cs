using DesigenPatternsAvigailAndRivkiKafirerya;
using DesigenPatternsAvigailAndRivkiKafirerya.Worker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAvigailAndRivkiCafiterya
{
    internal class Order
    {
        private static int staticId = 1;
        private OrderState State;
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public List<List<int>> MyProductOrder { get; set; }
        public double Payment { get; set; }
        public Order(Client client, List<List<int>> myProductOrder)
        {
            Debug.WriteLine("Order");
            Id = staticId++;
            Date = DateTime.Now;
            Client = client;
            MyProductOrder = myProductOrder;
            State = new AtTheCustomer(this);
        }
        public Order()
        {

        }
        public void ChangeState(OrderState state)
        {
            State = state;
            Restaurant r = Restaurant.GetInstance();
            string sendToForm = $" The order {Client.Name},{State.StateString} ";
            r.MyForm.State(sendToForm);
            Debug.WriteLine("ChangeState on Order");
        }
        public void OrderAtTheCustomer()
        {
            Debug.WriteLine("OrderAtTheCustomer on Order");
            State.OrderAtTheCustomer();
        }
        public void OrderTransferredToWaiter()
        {
            Debug.WriteLine("OrderTransferredToWaiter on Order");
            State.OrderTransferredToWaiter();
        }
        public void OrderMovedToTheKitchen()
        {
            Debug.WriteLine("OrderMovedToTheKitchen on Order");
            State.OrderMovedToTheKitchen();
        }
        public void OrderCanceledDueToLackOfMaterials()
        {
            Debug.WriteLine("OrderCanceledDueToLackOfMaterials on Order");
            State.OrderCanceledDueToLackOfMaterials();
        }
        public void OrderInTreatment()
        {
            Debug.WriteLine("OrderInTreatment on Order");
            State.OrderInTreatment();
        }

        public void OrderTheOrderHasBeenPlaced()
        {
            Debug.WriteLine("OrderTheOrderHasBeenPlaced on Order");
            State.OrderTheOrderHasBeenPlaced();
        }
        public void OrderAwaitingPayment()
        {
            Debug.WriteLine("OrderAwaitingPayment on Order");
            State.OrderAwaitingPayment();
        }
        public void OrderTheOrderHasEnded()
        {
            Debug.WriteLine("OrderTheOrderHasEnded on Order");
            State.OrderTheOrderHasEnded();
        }
        public Order Clone()
        {
            Debug.WriteLine("Clone on Order");
            Order copyOrder = new Order(Client, MyProductOrder);
            return copyOrder;
        }
    }
}
