using DesigenPatternsAvigailAndRivkiKafirerya.Drinks;
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
    internal class Restaurant
    {
        public Form1 MyForm { get; set; }
        public Waiter MyWaiter { get; set; }
        public Waiter OldWaiter { get; set; }
        public Waiter KindWaiter { get; set; }
        public Waiter FatWaiter { get; set; }
        public ResponsibleForKitchen MyResponsibleForKitchen { get; set; }
        public ChefFactory MyChefFactory { get; set; }
        public ColdDrinkMachine ColdDrinkMachine { get; set; }
        public HotDrinkMachine HotDrinkMachine { get; set; }
        public Computer MyComputer { get; set; }
        public List<Order> OrderForThisDay { get; set; }
        public Queue<Waiter> Waiters { get; set; }
        static Restaurant restaurant;
        private Restaurant()
        {
            Debug.WriteLine("Restaurant ctor");
            StrategyAllOrders strategyAllOrders = new Json();
            ColdDrinkMachine = new();
            HotDrinkMachine = new();
            MyWaiter = new();
            OldWaiter = new();
            KindWaiter = new();
            FatWaiter = new();
            MyResponsibleForKitchen = new();
            MyChefFactory = new();
            MyComputer = new(strategyAllOrders);
            OrderForThisDay = new();
            Waiters = new();
            Waiters.Enqueue(MyWaiter);
            Waiters.Enqueue(OldWaiter);
            Waiters.Enqueue(KindWaiter);
            Waiters.Enqueue(FatWaiter);
        }
        public static Restaurant GetInstance()
        {
            Debug.WriteLine("Restaurant GetInstance");
            if (restaurant == null)
            {
                restaurant = new Restaurant();
            }
            return restaurant;
        }
        public void AddOrder(Order order)
        {
            OrderForThisDay.Add(order);
        }
        public void RemoveOrder(Order order)
        {
            OrderForThisDay.Remove(order);
        }
        public Waiter GeteWaiter()
        {
            return Waiters.Dequeue();
        }
        public void WaiterFinish(Waiter w)
        {
            Waiters.Enqueue(w);
        }
        public void UpdateOrder(int id)
        {
            foreach (var item in OrderForThisDay)
            {
                if (item.Id == id)
                {
                    Debug.WriteLine($"the order{item.Client.Name} finish");
                    item.OrderTheOrderHasEnded();
                    break;
                }
            }
        }
    }
}
