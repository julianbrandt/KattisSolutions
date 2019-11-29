using System;
using System.Collections.Generic;
using System.Linq;

namespace Cetvrta
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 0;
            
            var c1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var c2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var c3 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            if (c1[0] == c2[0]) x = c3[0];
            else if (c1[0] == c3[0]) x = c2[0];
            else x = c1[0];
            
            if (c1[1] == c2[1]) y = c3[1];
            else if (c1[1] == c3[1]) y = c2[1];
            else y = c1[1];

            Console.WriteLine($"{x} {y}");
        }
    }
}