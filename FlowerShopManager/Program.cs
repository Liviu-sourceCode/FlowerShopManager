using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlowerShop flowerShop = new FlowerShop();

            Console.WriteLine("Vanzarile pe luna Noiembrie (30 zile):");

            // Selling bouquets (big, medium, small)
            flowerShop.SellBouquets(13, 10, 12);

            // Selling individual flowers (roses, gladiolus, hydrangeas)
            flowerShop.SellIndividualFlowers(15, 10, 25);

            Console.ReadLine(); // Keep the console open to view the output
        }
    }
}
