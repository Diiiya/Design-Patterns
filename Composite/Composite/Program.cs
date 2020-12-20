using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGraphic> compositeGraph = new List<IGraphic>();
            IGraphic dot = new Dot(1, 3);
            IGraphic line = new Line(1, 6);
            compositeGraph.Add(dot);
            compositeGraph.Add(line);

            foreach (var element in compositeGraph)
            {
                element.Draw();
            }

            Console.WriteLine("------");
        }
    }
}
