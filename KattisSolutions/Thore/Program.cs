using System;
using System.Collections.Generic;
using System.Text;

namespace Thore
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var people = new List<string>();
            for (var i = 0; i < lines; i++)
            {
                people.Add(Console.ReadLine());
            }

            var thoresName = "ThoreHusfeldt";
            var thore = people.IndexOf("ThoreHusfeldt");

            if (thore == 0)
            {
                Console.WriteLine("Thore is awesome");
                return;
            }
            
            string smallestPrefix = "";

            for (var i = 0; i < thore; i++)
            {
                if (people[i].Length >= 12 && people[i].Substring(0, 12) == "ThoreHusfeld")
                {
                    Console.WriteLine("Thore sucks");
                    return;
                }
                
                var prefix = new StringBuilder();
                for (var j = 0; j < thoresName.Length; j++)
                {
                    if (people[i].Length > j && people[i][j] == thoresName[j] && j < 11) prefix.Append(thoresName[j]);
                    else
                    {
                        prefix.Append(thoresName[j]);
                        if (prefix.ToString().Length > smallestPrefix.Length) smallestPrefix = prefix.ToString();
                        break;
                    }
                }
            }
            
            Console.WriteLine(smallestPrefix);
        }
    }
}