using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Line : IGraphic
    {
        int x, y;
        public Line(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a line at " + this.x + " and " + this.y);
        }

        public override void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }
}
