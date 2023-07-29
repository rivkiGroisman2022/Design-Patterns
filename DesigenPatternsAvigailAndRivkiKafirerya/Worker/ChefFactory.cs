using DesigenPatternsAvigailAndRivkiKafirerya.Drinks;
using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker

{
    internal class ChefFactory : IInformer
    {
        Restaurant restaurant = null;
        List<IObserver> myObservers = new();
        Queue<OrderReady> myFinishOrders = new();
        Queue<Order> myDoOrders = new();
        //public List<Product> Myproducts { get; set; }
        public ChefFactory()
        {
            Debug.WriteLine("ChefFactory ctor");
            // Myproducts = new();
        }
        public void Attach(IObserver observer)
        {
            Debug.WriteLine("Attach ChefFactory");
            myObservers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Debug.WriteLine("Detach ChefFactory");
            myObservers.Remove(observer);
        }

        public void Make(Order order)
        {
            Debug.WriteLine("Make ChefFactory");
            List<Product> Myproducts = new();
            restaurant = Restaurant.GetInstance();
            foreach (List<int> item in order.MyProductOrder)
            {
                Product p = null;
                if (item[0] == (int)(ProductEnum.waffale))
                {
                    if (item[1] == (int)(ProductEnum.circle))
                    {
                        p = new CircleWaffle();
                    }
                    else
                    {
                        p = new SquareWaffle();
                    }
                    for (int i = 2; i < item.Count; i++)
                    {
                        switch (item[1])
                        {
                            case (int)(ProductEnum.chocolate):
                                p = new ChoclateDecorator((Waffle)p);
                                break;
                            case (int)(ProductEnum.fruit):
                                p = new FruitDecorator((Waffle)p);
                                break;
                            case (int)(ProductEnum.pekan):
                                p = new PekanDecorator((Waffle)p);
                                break;
                            case (int)(ProductEnum.cookies):
                                p = new CookiesDecorator((Waffle)p);
                                break;
                            default:
                                break;
                        }
                        continue;
                    }
                    Myproducts.Add(p);
                    continue;
                }
                if (item[0] == (int)(ProductEnum.drink))
                {
                    if (item[1] == (int)(ProductEnum.coldDrink))
                    {
                        if (item[2] == (int)(ProductEnum.orangeJuice))
                        {
                            p = new OrangeJuice();
                            restaurant.ColdDrinkMachine.Make((OrangeJuice)p);
                            Myproducts.Add(p);
                            continue;
                        }
                        p = new Limonada();
                        restaurant.ColdDrinkMachine.Make((Limonada)p);
                        Myproducts.Add(p);
                        continue;
                    }
                    if (item[1] == (int)(ProductEnum.hotDrink))
                    {
                        if (item[2] == (int)(ProductEnum.coffee))
                        {
                            p = new coffee();
                            restaurant.HotDrinkMachine.Make((coffee)p);
                            Myproducts.Add(p);
                            continue;
                        }
                        p = new Shoko();
                        restaurant.HotDrinkMachine.Make((Shoko)p);
                        Myproducts.Add(p);
                        continue;
                    }
                }
                Myproducts.Add(p);
            }
            OrderReady orderFinish = new(order, Myproducts);
            myFinishOrders.Enqueue(orderFinish);
            Notify();

        }
        public void Notify()
        {
            Debug.Write("Notify ChefFactory");
            myObservers[0].Ready(myFinishOrders.Dequeue());
        }
    }
}
