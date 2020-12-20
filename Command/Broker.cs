using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Broker
    {
        private List<Order> orders = new List<Order>();

        public void TakeOrder(Order order)
        {
            orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (Order order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
