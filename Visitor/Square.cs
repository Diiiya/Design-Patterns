using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Square : Shape
    {
        public void Accept(Visitor v)
        {
            v.VisitSquare(this);
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
