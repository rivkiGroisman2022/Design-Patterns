using DesigenPatternsAvigailAndRivkiKafirerya;
using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal class Waiter : IObserver
    {
        public int id { get; set; }
        public Order MyOrder { get; set; }
        public void GetOrder(Order order)
        {
            Debug.WriteLine("GetOrder Waiter");
            MyOrder = order;
            MyOrder.OrderTransferredToWaiter();
            if (MyOrder.Date.Hour > 20)
            {
                MyOrder.OrderCanceledDueToLackOfMaterials();
                return;
            }
            Restaurant restaurant = Restaurant.GetInstance();
            ResponsibleForKitchen MyR = restaurant.MyResponsibleForKitchen;
            MyR.Attach(this);
            MyR.GetOrder(MyOrder);
        }
        public double ConsiderPayment(double Sum)
        {
            Debug.WriteLine("ConsiderPayment Waiter");
            return Sum;
        }
        public void Ready(OrderReady orderReady)
        {
            Debug.WriteLine("ConsiderPayment Ready");
            orderReady.order.OrderTransferredToWaiter();
            double Sum = 0;
            foreach (var item in orderReady.MyproductsReady)
            {
                Sum += item.GetCost();
            }
            orderReady.order.OrderAwaitingPayment();
            orderReady.order.Payment = Sum;
            Restaurant restaurant = Restaurant.GetInstance();
            restaurant.WaiterFinish(this);
            restaurant.MyForm.ShowPayment(orderReady.order.Client.Name, orderReady.order.Payment, orderReady.order.Id);
        }

    }
}
