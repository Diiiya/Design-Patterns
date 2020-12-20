using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Shake
    {
        public abstract void PickCreamBase();
        public abstract void PickGreenVeg();
        public abstract void PickLiquid();

        public virtual void MakeShake()
        {
            PickCreamBase();
            PickGreenVeg();
            PickLiquid();
        }

    }
}
