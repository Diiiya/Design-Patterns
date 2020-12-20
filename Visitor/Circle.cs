using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Circle : Shape
    {
        public void Accept(Visitor v)
        {
            v.VisitCircle(this);
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
