using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class GreenShake : Shake
    {
        public override void PickCreamBase()
        {
            Console.WriteLine("Avocado base");
        }

        public override void PickGreenVeg()
        {
            Console.WriteLine("Spinach veggie");
        }

        public override void PickLiquid()
        {
            Console.WriteLine("Coconut milk");
        }
    }
}
