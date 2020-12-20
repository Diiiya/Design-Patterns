using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Shake shake = new PowerShake();
            shake.MakeShake();
            Console.WriteLine();

            Console.WriteLine("~~~");
        }
    }
}
