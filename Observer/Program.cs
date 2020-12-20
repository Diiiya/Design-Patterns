using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new BinaryObserver(subject);
            new OctalObserver(subject);

            Console.WriteLine("--- State: 10 ---");
            subject.SetState(10);
            Console.WriteLine();
            Console.WriteLine("--- State: 20 ---");
            subject.SetState(20);
            Console.WriteLine();
            Console.WriteLine("~~~");
        }
    }
}
