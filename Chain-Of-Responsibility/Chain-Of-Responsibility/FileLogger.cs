using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine("File Logger: " + message);
        }
    }
}
