using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        Strategy strategy;

        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return strategy.Execute(a, b);
        }
    }
}
