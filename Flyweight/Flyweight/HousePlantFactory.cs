using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class HousePlantFactory
    {
        static List<HousePlantTypeF> housePlants = new List<HousePlantTypeF>()
        {
            new HousePlantTypeF("Monstera", "Dark Green", false),
            new HousePlantTypeF("Aloe vera", "Dark Green", false),
            new HousePlantTypeF("Orchid", "Olive Green", true),
            new HousePlantTypeF("Coffee arabica", "Dark Green", false),
            new HousePlantTypeF("Kalanhoe", "Light Green", true),
        };

        public static HousePlantTypeF GetPlant(string name, string color, bool blooms)
        {
            HousePlantTypeF type = housePlants.Find(housePlants => housePlants.name == name && housePlants.color == color && housePlants.blooms == blooms);
            if (type == null)
            {
                type = new HousePlantTypeF(name, color, blooms);
                housePlants.Add(type);
            }
            return type;
        }

        public static int GetNumOfTypes()
        {
            return housePlants.Count;
        }
    }
}
