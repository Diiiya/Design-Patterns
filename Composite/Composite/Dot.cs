using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Dot : IGraphic
    {
        int x, y;

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a dot at " + this.x + " and " + this.y);
        }

        public override void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }
}
