using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    class ConsoleLogger : AbstractLogger
    {
        //int level;
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standart Console Logger: " + message);
        }
    }
}
