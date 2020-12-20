using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class PowerShake : Shake
    {
        public override void PickCreamBase()
        {
            Console.WriteLine("Banana cream base");
        }

        public override void PickGreenVeg()
        {
            Console.WriteLine("Spinach veggie");
        }

        public override void PickLiquid()
        {
            Console.WriteLine("Vanilia milk");
        }
    }
}
