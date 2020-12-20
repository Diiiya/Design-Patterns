using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class SellStock : Order
    {
        private Stock roses;

        public SellStock(Stock stock)
        {
            roses = stock;
        }
        public void Execute()
        {
            roses.SellStock();
        }
    }
}
