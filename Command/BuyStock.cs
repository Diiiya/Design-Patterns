using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class BuyStock : Order
    {
        private Stock roses;

        public BuyStock(Stock stock)
        {
            roses = stock;
        }
        public void Execute()
        {
            roses.BuyStock();
        }
    }
}
