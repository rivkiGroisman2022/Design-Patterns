using DesignPatternsAvigailAndRivkiCafiterya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesigenPatternsAvigailAndRivkiKafirerya.Worker
{
    internal class Json : StrategyAllOrders
    {
        public string FileName1 { get; set; }
        public Json()
        {
            FileName1 = "Order.json";
            Debug.WriteLine("Json");
        }

        public List<Order> FindOrder(string name, DateTime date)
        {
            Debug.WriteLine("FindOrder");
            List<Order> find = new();
            List<Order> myOrders = Loud();
            if (myOrders != null)
            {
                foreach (Order o in myOrders)
                {
                    if (o.Client.Name.Equals(name))
                    {
                        find.Add(o);
                    }
                }
            }
            return find;
        }

        public List<Order> Loud()
        {
            Debug.WriteLine("Loud");
            string jsonString = File.ReadAllText(FileName1);
            List<Order> orders = JsonSerializer.Deserialize<List<Order>>(jsonString)!;
            return orders;
        }

        public void SaveMe(Order orderToSave)
        {
            Debug.WriteLine("SaveMe");
            List<Order> myOrders = new();
            string jsonString = File.ReadAllText(FileName1);
            if (jsonString == "")
            {
                myOrders.Add(orderToSave);
                jsonString = JsonSerializer.Serialize(myOrders);
                File.WriteAllText(FileName1, jsonString);
            }
            myOrders = Loud();
            myOrders.Add(orderToSave);
            jsonString = JsonSerializer.Serialize(myOrders);
            File.WriteAllText(FileName1, jsonString);
        }


    }
}
