using System;
using System.Collections.Generic;

namespace IveBeenEverywhereMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                var cities = new HashSet<string>();
                
                var lines = int.Parse(Console.ReadLine());
                for (int j = 0; j < lines; j++)
                {
                    cities.Add(Console.ReadLine());
                }
                
                Console.WriteLine(cities.Count);
            }
        }
    }
}