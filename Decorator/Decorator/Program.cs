using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Order an M size bouquet of Roses with packaging: box and a label---");
            IBouquet bouquet1 = new Roses(BouquetSize.M);
            Console.WriteLine("Base: " + bouquet1.GetDescription() + " that costs " + bouquet1.GetPrice() + "DKK");
            Additions bouquet1WithAdditions = new Box(bouquet1);
            bouquet1WithAdditions = new Label(bouquet1WithAdditions);
            Console.WriteLine("Base: " + bouquet1WithAdditions.GetDescription() + " that costs " + bouquet1WithAdditions.GetPrice() + "DKK in total");
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine();

            Console.WriteLine("--- Order an S size bouquet of Amaryllis with packaging: paper and a label ---");
            IBouquet bouquet2 = new Amaryllis(BouquetSize.S);
            Console.WriteLine("Base: " + bouquet2.GetDescription() + " that costs " + bouquet2.GetPrice() + "DKK");
            Additions bouquet2WithAdditions = new Paper(bouquet2);
            bouquet2WithAdditions = new Label(bouquet2WithAdditions);
            Console.WriteLine("Base: " + bouquet2WithAdditions.GetDescription() + " that costs " + bouquet2WithAdditions.GetPrice() + "DKK in total");
            Console.WriteLine();
            Console.WriteLine("-------");
        }
    }
}
