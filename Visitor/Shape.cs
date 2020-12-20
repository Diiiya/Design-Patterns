using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface Shape
    {
        public void Move(int x, int y);
        public void Draw();
        public void Accept(Visitor v);
    }
}
