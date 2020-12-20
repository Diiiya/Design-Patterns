using System;

namespace Chain_Of_Responsibility
{
    class Program
    {
        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUg);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
        static void Main(string[] args)
        {
            AbstractLogger chain = GetChainOfLoggers();

            chain.LogMessage(AbstractLogger.INFO, "Info message client");
            Console.WriteLine("---");
            chain.LogMessage(AbstractLogger.DEBUg, "Debug message client");
            Console.WriteLine("---");
            chain.LogMessage(AbstractLogger.ERROR, "Error message client");


            Console.WriteLine("-----------");
        }
    }
}
