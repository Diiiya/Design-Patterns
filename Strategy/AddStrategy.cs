using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class AddStrategy : Strategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
