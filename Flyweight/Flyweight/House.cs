using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class House
    {
        static List<HousePlantContext> housePlants = new List<HousePlantContext>();

        public static int GetPlantsNum()
        {
            return housePlants.Count;
        }

        // CW prints how many static plant objects (types) there are ready to be used
        // If a new one is created, the number should increase
        public static void AddHousePlant(int x, int y, string name, string color, bool blooms)
        {
            HousePlantTypeF housePlantType = HousePlantFactory.GetPlant(name, color, blooms);
            HousePlantContext housePlant = new HousePlantContext(x, y, housePlantType);
            housePlants.Add(housePlant);
            Console.WriteLine("Plant types count: " + HousePlantFactory.GetNumOfTypes());
        }

        public static void Draw(string canvas)
        {
            foreach (HousePlantContext housePlant in housePlants)
            {
                housePlant.Draw(canvas);
            }
        }
    }
}
