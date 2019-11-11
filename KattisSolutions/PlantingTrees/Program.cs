using System;
using System.Linq;

namespace PlantingTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var trees = Int32.Parse(Console.ReadLine());
            string[] days = Console.ReadLine().Split(" ");
            int[] daysInts = new int[trees];

            for (int i = 0; i < trees; i++)
            {
                daysInts[i] = Int32.Parse(days[i]);
            }

            Array.Sort<int>(daysInts,
                new Comparison<int>(
                    (i1, i2) => i2.CompareTo(i1)
                ));

            for (int i = 0; i < days.Length; i++)
            {
                daysInts[i] = daysInts[i] + i + 2;
            }
            
            Console.WriteLine(daysInts.Max());
        }
    }
}