using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MultiplyStrategy : Strategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
