using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class HousePlantTypeF
    {
        public string name;
        public string color;
        public bool blooms;

        public HousePlantTypeF(string name, string color, bool blooms)
        {
            this.name = name;
            this.color = color;
            this.blooms = blooms;
        }

        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine("Draw " + this.color + " " + this.name + " on canvas: " + canvas + " at coordinates: " + x + ", " + y);
        }
    }
}
