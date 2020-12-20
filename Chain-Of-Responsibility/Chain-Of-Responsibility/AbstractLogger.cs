using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility
{
    abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUg = 2;
        public static int ERROR = 3;

        protected int level;
        protected AbstractLogger currentLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.currentLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }
            if (currentLogger != null)
            {
                currentLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(string message);

    }
}
