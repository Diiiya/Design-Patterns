using System;

namespace Mediator
{
    class Program
    {
        // Mediator pattern > 
        //  - Behavioral Pattern
        //  - An event fired for ONE Component, can trigger events in OTHER Components
        //  - Mediator stands in between the communication of all components so that they dont interact with each other directly
        static void Main(string[] args)
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Test opration A:");
            component1.DoA();

            Console.WriteLine();
            Console.WriteLine("-");
            Console.WriteLine();

            Console.WriteLine("Test opration B:");
            component1.DoB();

            Console.WriteLine();
            Console.WriteLine("-");
            Console.WriteLine();

            Console.WriteLine("Test opration D:");
            component2.DoD();

            Console.WriteLine("--- EnD ---");
        }
    }
}
