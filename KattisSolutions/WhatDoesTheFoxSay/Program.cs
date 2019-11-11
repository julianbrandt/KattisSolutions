using System;
using System.Linq;
using System.Text;

namespace WhatDoesTheFoxSay
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {
                var words = Console.ReadLine().Split().ToList();

                string line;
                while ((line = Console.ReadLine()) != "what does the fox say?")
                {
                    var split = line.Split(" ");
                    var sound = split[split.Length - 1];
                    while (words.Contains(sound))
                    {
                        words.Remove(sound);
                    }
                }

                var output = string.Join(" ", words.ToArray());
                Console.WriteLine(output);
            }
        }
    }
}