using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class HousePlantContext
    {
        int x, y;
        HousePlantTypeF type;
        public HousePlantContext(int x, int y, HousePlantTypeF type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void Draw(string canvas)
        {
            type.Draw(canvas, this.x, this.y);
        }
    }
}
