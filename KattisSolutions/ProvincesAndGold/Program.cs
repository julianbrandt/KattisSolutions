using System;
using System.Linq;

namespace ProvincesAndGold
{
    class Program
    {
        static void Main(string[] args)
        {
            var gsc = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            var buyingPower = gsc[0] * 3 + gsc[1] * 2 + gsc[2];

            string bestVictory = null;
            var bestTreasure = "Copper";

            if (buyingPower >= 8)
            {
                bestVictory = "Province";
            }
            else if (buyingPower >= 5)
            {
                bestVictory = "Duchy";
            }
            else if (buyingPower >= 2)
            {
                bestVictory = "Estate";
            }

            if (buyingPower >= 6)
            {
                bestTreasure = "Gold";
            }
            else if (buyingPower >= 3)
            {
                bestTreasure = "Silver";
            }

            if (bestVictory == null)
            {
                Console.WriteLine(bestTreasure);
            }
            else
            {
                Console.WriteLine($"{bestVictory} or {bestTreasure}");
            }
        }
    }
}