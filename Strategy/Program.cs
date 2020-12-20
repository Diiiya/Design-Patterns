using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Console.WriteLine("Insert number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert strategy (type add, subs or multi) : ");
            string strategy = Console.ReadLine();

            switch (strategy)
            {
                case "add":
                    context.SetStrategy(new AddStrategy());
                    break;
                case "subs":
                    context.SetStrategy(new SubstractStrategy());
                    break;
                case "multi":
                    context.SetStrategy(new MultiplyStrategy());
                    break;
                default:
                    break;
            }

            int result = context.ExecuteStrategy(a, b);
            Console.WriteLine("Result: " + result);

            Console.WriteLine("~~~");
        }
    }
}
