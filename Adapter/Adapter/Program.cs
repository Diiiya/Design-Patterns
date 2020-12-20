using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ExternalLibrary externalLibrary = new ExternalLibrary();
            ITarget target = new Adapter(externalLibrary);
            Console.WriteLine(target.GetRequest());
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }
}
