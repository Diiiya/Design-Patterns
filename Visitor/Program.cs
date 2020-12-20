using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square());
            shapes.Add(new Dot());
            shapes.Add(new Circle());

            XMLExportVisitor xmlVisitor = new XMLExportVisitor();
            foreach (Shape shape in shapes)
            {
                shape.Accept(xmlVisitor);
            }

            Console.WriteLine("~~~");
        }
    }
}
