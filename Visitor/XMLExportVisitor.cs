using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class XMLExportVisitor : Visitor
    {
        public void VisitCircle(Circle c)
        {
            Console.WriteLine("Exported circle logic");
        }

        public void VisitDot(Dot d)
        {
            Console.WriteLine("Exported dot logic");
        }

        public void VisitSquare(Square s)
        {
            Console.WriteLine("Exported square logic");
        }
    }
}
