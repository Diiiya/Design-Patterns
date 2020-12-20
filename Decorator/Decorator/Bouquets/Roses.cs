using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Roses : IBouquet
    {
        BouquetSize size;
        double price;
        public Roses(BouquetSize size)
        {
            if (size.ToString() == "S")
            {
                this.price = 50;
            }
            else if (size.ToString() == "M")
            {
                this.price = 100;
            } else
            {
                this.price = 200;
            }
        }
        public string GetDescription()
        {
            return this.size + " size bouquet of Roses ordered!";
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
