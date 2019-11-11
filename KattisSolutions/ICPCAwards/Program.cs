using System;
using System.Collections.Generic;
using System.Linq;

namespace ICPCAwards
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var universities = new HashSet<string>();

            for (var i = 0; i < lines; i++)
            {
                var line = Console.ReadLine();
                var splitLine = line.Split(" ");
                if (!universities.Contains(splitLine[0]))
                {
                    universities.Add(splitLine[0]);
                    Console.WriteLine(line);
                }

                if (universities.Count == 12) return;
            }
        }
    }
}