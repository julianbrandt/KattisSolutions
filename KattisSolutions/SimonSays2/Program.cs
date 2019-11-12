using System;

namespace SimonSays2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (var i = 0; i < lines; i++)
            {
                var line = Console.ReadLine();
                var split = line.Split(" ");

                if (split.Length > 1 && split[0].ToLower().Equals("simon") && split[1].ToLower().Equals("says"))
                {
                    Console.WriteLine(line.Substring(10, line.Length-10));
                }
            }
        }
    }
}