using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Paper : Additions
    {
        public Paper(IBouquet gift) : base(gift)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + paper";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}
