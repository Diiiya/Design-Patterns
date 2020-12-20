using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Box : Additions
    {
        public Box(IBouquet gift) : base(gift)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + box";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 20;
        }
    }
}
