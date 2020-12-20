using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine("Error logger: " + message);
        }
    }
}
