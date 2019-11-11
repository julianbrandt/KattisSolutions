using System;
using System.Collections.Generic;
using System.Linq;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new List<int>();
            
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var score = line.Split(" ").Sum(s => int.Parse(s.ToString()));

                scores.Add(score);
            }
            
            Console.WriteLine((scores.IndexOf(scores.Max()) + 1) + " " + scores.Max());
        }
    }
}