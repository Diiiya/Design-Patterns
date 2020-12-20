using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Label : Additions
    {
        public Label(IBouquet gift) : base(gift)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + label";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}
