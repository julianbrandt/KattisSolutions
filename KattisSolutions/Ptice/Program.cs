using System;
using System.Collections.Generic;
using System.Linq;

namespace Ptice
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = int.Parse(Console.ReadLine());
            var adrian =
                "ABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCABCA"
                    .ToCharArray();
            var bruno =
                "BABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABCBABC"
                    .ToCharArray();
            var goran =
                "CCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAABBCCAA"
                    .ToCharArray();

            var input = Console.ReadLine().ToCharArray();

            var adrianScore = 0;
            var brunoScore = 0;
            var goranScore = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(adrian[i])) adrianScore++;
                if (input[i].Equals(bruno[i])) brunoScore++;
                if (input[i].Equals(goran[i])) goranScore++;
            }

            var sortedScores = new Dictionary<string, int>()
            {
                {"Adrian", adrianScore},
                {"Bruno", brunoScore},
                {"Goran", goranScore}
            };

            var highest = sortedScores.Values.Max();
            Console.WriteLine(highest);
            foreach (var kvp in sortedScores)
            {
                if (kvp.Value == highest)
                    Console.WriteLine(kvp.Key);
            }
        }
    }
}