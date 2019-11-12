using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SymmetricOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines;
            var set = 0;
            while ((lines = int.Parse(Console.ReadLine())) != 0)
            {
                set++;
                Console.WriteLine("SET " + set);
                var names = new List<string>();
                for (var i = 0; i < lines; i++)
                {
                    names.Add(Console.ReadLine());
                }

                names.Sort((a, b) => a.Length.CompareTo(b.Length));
                var sortedNames = new List<string>();
                var counter = 0;
                while (counter < names.Count)
                {
                    sortedNames.Add(names[counter]);
                    counter += 2;
                }
                
                if (names.Count % 2 == 0) counter = names.Count - 1;
                else counter = names.Count - 2;
                while (counter > 0)
                {
                    sortedNames.Add(names[counter]);
                    counter -= 2;
                }

                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}