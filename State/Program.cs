using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            StartState startState = new StartState();
            startState.DoAction(context);
            context.GetState().ToString();
            Console.WriteLine();

            StopState stopState = new StopState();
            stopState.DoAction(context);
            context.GetState().ToString();
            Console.WriteLine("~~~");
        }
    }
}
