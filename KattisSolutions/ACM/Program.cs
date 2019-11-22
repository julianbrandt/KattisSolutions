using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM
{
    class Program
    {
        static void Main(string[] args)
        {
            var exerciseTime = new Dictionary<char, int>();
            var exercisePenalty = new Dictionary<char, int>();
            var exerciseSolved = new List<char>();

            string line;
            while ((line = Console.ReadLine()) != "-1")
            {
                var split = line.Split(" ");
                var time = int.Parse(split[0]);
                var letter = split[1].ToCharArray()[0];
                var answer = split[2] == "right";

                if (!exerciseTime.ContainsKey(letter))
                {
                    exerciseTime.Add(letter, time);
                    exercisePenalty.Add(letter, 0);
                }
                else
                {
                    exerciseTime[letter] = time;
                }

                if (answer)
                {
                    exerciseSolved.Add(letter);
                }
                else
                {
                    exercisePenalty[letter] += 20;
                }
            }

            var solved = exerciseSolved.Count;
            var totalTime = exerciseTime.Where(ex => exerciseSolved
                                            .Contains(ex.Key))
                                            .Sum(ex => ex.Value) + exerciseSolved
                                                .Sum(ex => exercisePenalty[ex]);

            Console.WriteLine(solved + " " + totalTime);
        }
    }
}