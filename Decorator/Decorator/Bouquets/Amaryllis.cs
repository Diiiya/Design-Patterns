using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Amaryllis : IBouquet
    {
        BouquetSize size;
        double price;

        public Amaryllis(BouquetSize size)
        {
            if (size.ToString() == "S")
            {
                this.price = 50;
            }
            else if (size.ToString() == "M")
            {
                this.price = 100;
            }
            else
            {
                this.price = 200;
            }
        }
        public string GetDescription()
        {
            return this.size + " size bouquet of Amaryllis ordered.";
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
