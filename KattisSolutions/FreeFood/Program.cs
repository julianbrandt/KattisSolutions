using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = new HashSet<int>();
            var cases = int.Parse(Console.ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var dates = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                for (var j = dates[0]; j <= dates[1]; j++)
                {
                    days.Add(j);
                }
            }
            Console.WriteLine(days.Count);
        }
    }
}