using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string canvas = "First";

            House.AddHousePlant(1, 2, "Monstera", "Dark Green", false);
            House.AddHousePlant(3, 2, "Monstera", "Dark Green", false);
            House.AddHousePlant(5, 2, "Monstera", "Dark Green", false);
            House.AddHousePlant(7, 2, "Rose", "Red", true);

            House.Draw(canvas);
            // Prints how many unique objects are created
            Console.WriteLine("Plants in the list: " + House.GetPlantsNum());

            Console.WriteLine("-----------------");
        }
    }
}
