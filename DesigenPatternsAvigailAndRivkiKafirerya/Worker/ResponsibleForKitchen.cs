using DesigenPatternsAvigailAndRivkiKafirerya;
using DesigenPatternsAvigailAndRivkiKafirerya.Worker;
using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal class ResponsibleForKitchen : IObserver, IInformer
    {
        public List<Order> OurOrder { get; set; }
        Restaurant restaurant = null;
        List<IObserver> waiterObserver = new();
        Stack<OrderReady> orders = new();
        // public List<Product> myProducts { get; set; }
        public ResponsibleForKitchen()
        {
            Debug.WriteLine("ResponsibleForKitchen ctor");
            OurOrder = new();
        }
        public void Attach(IObserver observer)
        {
            Debug.WriteLine("ResponsibleForKitchen Attach");
            waiterObserver.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Debug.WriteLine("ResponsibleForKitchen Detach");
            waiterObserver.Remove(observer);

        }

        public void GetOrder(Order order)
        {
            Debug.WriteLine("ResponsibleForKitchen GetOrder");
            OurOrder.Add(order);
            restaurant = Restaurant.GetInstance();
            restaurant.AddOrder(order);
            order.OrderMovedToTheKitchen();
            restaurant.MyChefFactory.Attach(this);
            order.OrderInTreatment();
            restaurant.MyChefFactory.Make(order);
        }

        public void Notify()
        {
            Debug.WriteLine("ResponsibleForKitchen Notify");
            OrderReady orderReady = orders.Pop();
            Waiter w = null;
            foreach (var item in waiterObserver)
            {
                w = (Waiter)item;
                if (w.MyOrder.Id == orderReady.order.Id)
                {
                    break;
                    //maby remove order
                }
            }
            w.Ready(orderReady);
            Detach(w);
        }



        public void Ready(OrderReady orderReady)
        {
            Debug.WriteLine("ResponsibleForKitchen Ready");
            foreach (var item in OurOrder)
            {
                if (item.Id == orderReady.order.Id)
                {
                    item.OrderTheOrderHasBeenPlaced();
                    //maby remove order
                }
            }
            //  OurOrder.Dequeue().OrderTheOrderHasBeenPlaced();
            orders.Push(orderReady);
            Notify();
        }
    }
}
