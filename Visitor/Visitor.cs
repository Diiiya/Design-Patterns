using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface Visitor
    {
        public void VisitDot(Dot d);
        public void VisitSquare(Square s);

        public void VisitCircle(Circle c);
    }
}
