using System;
using System.Collections.Generic;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointsDominant = new Dictionary<char, int>()
            {
                {'A', 11},
                {'K', 4},
                {'Q', 3},
                {'J', 20},
                {'T', 10},
                {'9', 14},
                {'8', 0},
                {'7', 0},
            };
            
            var pointsNonDominant = new Dictionary<char, int>()
            {
                {'A', 11},
                {'K', 4},
                {'Q', 3},
                {'J', 2},
                {'T', 10},
                {'9', 0},
                {'8', 0},
                {'7', 0},
            };

            var firstLine = Console.ReadLine().Split(" ");
            var hands = int.Parse(firstLine[0]);
            var dominant = firstLine[1].ToCharArray()[0];
            
            var score = 0;
            for (var i = 0; i < hands; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var line = Console.ReadLine();
                    if (line[1].Equals(dominant))
                    {
                        score += pointsDominant[line[0]];
                    }
                    else
                    {
                        score += pointsNonDominant[line[0]];
                    }
                }
            }
            Console.WriteLine(score);
        }
    }
}