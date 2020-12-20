using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock roses = new Stock();
            BuyStock buyRoses = new BuyStock(roses);

            Broker broker = new Broker();
            broker.TakeOrder(buyRoses);
            broker.PlaceOrders();

            Console.WriteLine("~~~");
        }
    }
}
