using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Stock
    {
        private string name = "Roses";
        private int quantity = 10;

        public void BuyStock()
        {
            Console.WriteLine("Bought: " + name + " ~ " + quantity);
        }

        public void SellStock()
        {
            Console.WriteLine("Sold: " + name + " ~ " + quantity);
        }
    }
}
