using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Additions : IBouquet
    {
        private readonly IBouquet gift;

        public Additions(IBouquet gift)
        {
            this.gift = gift;
        }
        public virtual string GetDescription()
        {
            return this.gift.GetDescription();
        }

        public virtual double GetPrice()
        {
            return this.gift.GetPrice();
        }
    }
}
