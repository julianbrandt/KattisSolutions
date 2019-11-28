using System;
using System.Collections.Generic;

namespace DiceCup
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ");
            var die1 = int.Parse(line[0]);
            var die2 = int.Parse(line[1]);

            var outcomes = new Dictionary<int, int>();
            
            for (var i = 1; i <= die1; i++)
            {
                for (var j = 1; j <= die2; j++)
                {
                    if (!outcomes.ContainsKey(i + j))
                    {
                        outcomes.Add(i+j, 1);
                    }
                    else
                    {
                        outcomes[i + j]++;
                    }
                }
            }
            
            var commonRolls = new List<int>();
            var highestAmount = 0;
            foreach (var roll in outcomes)
            {
                if (roll.Value > highestAmount) highestAmount = roll.Value;
            }
            foreach (var roll in outcomes)
            {
                if (roll.Value == highestAmount) commonRolls.Add(roll.Key);
            }

            foreach (var roll in commonRolls)
            {
                Console.WriteLine(roll);
            }
        }
    }
}