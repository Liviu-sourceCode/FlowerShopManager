using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FlowerShop
    {
        private Dictionary<string, int> flowerPrices;

        public FlowerShop()
        {
            flowerPrices = new Dictionary<string, int>
        {
            { "Rose", 10 },
            { "Gladiolus", 15 },
            { "Hydrangea", 30 }
        };
        }

        // Method to sell a type of bouquet and track the flower usage
        private int SellBouquetType(int quantity, Bouquet bouquet, ref Dictionary<string, int> flowerUsage)
        {
            int pricePerBouquet = bouquet.CalculatePrice(flowerPrices);

            // Track flower usage for each bouquet
            foreach (var flower in bouquet.FlowerRequirements)
            {
                if (!flowerUsage.ContainsKey(flower.Key))
                    flowerUsage[flower.Key] = 0;

                flowerUsage[flower.Key] += flower.Value * quantity;
            }

            return quantity * pricePerBouquet;
        }

        public void SellBouquets(int bigBouquets, int mediumBouquets, int smallBouquets)
        {
            int numberOfDays = 30;

            int totalBigBouquets = bigBouquets * numberOfDays;
            int totalMediumBouquets = mediumBouquets * numberOfDays;
            int totalSmallBouquets = smallBouquets * numberOfDays;

            Dictionary<string, int> flowerUsage = new Dictionary<string, int>();

            int incomeBigBouquets = SellBouquetType(totalBigBouquets, new BigBouquet(), ref flowerUsage);
            int incomeMediumBouquets = SellBouquetType(totalMediumBouquets, new MediumBouquet(), ref flowerUsage);
            int incomeSmallBouquets = SellBouquetType(totalSmallBouquets, new SmallBouquet(), ref flowerUsage);

            Console.WriteLine($"Big Bouquets Sold: {totalBigBouquets}, Profit: {incomeBigBouquets} RON");
            Console.WriteLine($"Medium Bouquets Sold: {totalMediumBouquets}, Profit: {incomeMediumBouquets} RON");
            Console.WriteLine($"Small Bouquets Sold: {totalSmallBouquets}, Profit: {incomeSmallBouquets} RON");

            int totalIncome = incomeBigBouquets + incomeMediumBouquets + incomeSmallBouquets;
            Console.WriteLine($"Total Revenue from Bouquets: {totalIncome} RON");

            // Display the total flower usage
            foreach (var usage in flowerUsage)
            {
                Console.WriteLine($"Total {usage.Key} Used: {usage.Value}");
            }
        }

        // Method to sell individual flowers
        private int SellFlower(string flowerType, int quantity)
        {
            return quantity * flowerPrices[flowerType];
        }

        public void SellIndividualFlowers(int roses, int gladiolus, int hydrangeas)
        {
            int numberOfDays = 30;

            int totalRoses = roses * numberOfDays;
            int totalGladiolus = gladiolus * numberOfDays;
            int totalHydrangeas = hydrangeas * numberOfDays;

            int incomeRoses = SellFlower("Rose", totalRoses);
            int incomeGladiolus = SellFlower("Gladiolus", totalGladiolus);
            int incomeHydrangeas = SellFlower("Hydrangea", totalHydrangeas);

            Console.WriteLine($"Roses Sold: {totalRoses}, Profit: {incomeRoses} RON");
            Console.WriteLine($"Gladiolus Sold: {totalGladiolus}, Profit: {incomeGladiolus} RON");
            Console.WriteLine($"Hydrangeas Sold: {totalHydrangeas}, Profit: {incomeHydrangeas} RON");

            int totalIncome = incomeRoses + incomeGladiolus + incomeHydrangeas;
            Console.WriteLine($"Total Revenue from Individual Flowers: {totalIncome} RON");
        }
    }
}
