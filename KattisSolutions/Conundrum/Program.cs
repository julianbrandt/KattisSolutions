using System;

namespace Conundrum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var days = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (
                    i % 3 == 0 && input[i].Equals('P') ||
                    (i + 2) % 3 == 0 && input[i].Equals('E') ||
                    (i + 1) % 3 == 0 && input[i].Equals('R'))
                    continue;
                days++;
            }
            
            Console.WriteLine(days);
        }
    }
}