using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Lily : IBouquet
    {
        BouquetSize size;
        double price;
        public Lily(BouquetSize size)
        {
            if (size.ToString() == "S")
            {
                this.price = 30;
            }
            else if (size.ToString() == "M")
            {
                this.price = 60;
            }
            else
            {
                this.price = 90;
            }
        }
        public string GetDescription()
        {
            return this.size + " size bouquet of Lily ordered!";
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
