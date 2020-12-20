using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SubstractStrategy : Strategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
