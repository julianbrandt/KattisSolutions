using System;
using System.Linq;

namespace HotHike
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var temperatures = Console.ReadLine().Split(" ").Select(n => int.Parse(n.ToString())).ToList();

            var larger = 0;
            var best = int.MaxValue;
            var startIndex = int.MaxValue;
            
            for (var i = 2; i < days; i++)
            {
                var startDate = temperatures[i - 2];
                var endDate = temperatures[i];

                larger = startDate > endDate ? startDate : endDate;
                if (larger < best)
                {
                    best = larger;
                    startIndex = i - 2;
                }
            }
            
            Console.WriteLine((startIndex + 1) + " " + best);
        }
    }
}