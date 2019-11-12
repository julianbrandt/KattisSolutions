using System;

namespace FourThought
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (var i = 0; i < lines; i++)
            {
                var goal = int.Parse(Console.ReadLine());
                Console.WriteLine(fours(goal));
            }
        }

        static string fours(int goal)
        {
            if (4 + 4 + 4 + 4 == goal) return "4 + 4 + 4 + 4 = " + goal;
            if (4 + 4 + 4 - 4 == goal) return "4 + 4 + 4 - 4 = " + goal;
            if (4 + 4 + 4 * 4 == goal) return "4 + 4 + 4 * 4 = " + goal;
            if (4 + 4 + 4 / 4 == goal) return "4 + 4 + 4 / 4 = " + goal;
            if (4 + 4 - 4 + 4 == goal) return "4 + 4 - 4 + 4 = " + goal;
            if (4 + 4 - 4 - 4 == goal) return "4 + 4 - 4 - 4 = " + goal;
            if (4 + 4 - 4 * 4 == goal) return "4 + 4 - 4 * 4 = " + goal;
            if (4 + 4 - 4 / 4 == goal) return "4 + 4 - 4 / 4 = " + goal;
            if (4 + 4 * 4 + 4 == goal) return "4 + 4 * 4 + 4 = " + goal;
            if (4 + 4 * 4 - 4 == goal) return "4 + 4 * 4 - 4 = " + goal;
            if (4 + 4 * 4 * 4 == goal) return "4 + 4 * 4 * 4 = " + goal;
            if (4 + 4 * 4 / 4 == goal) return "4 + 4 * 4 / 4 = " + goal;
            if (4 + 4 / 4 + 4 == goal) return "4 + 4 / 4 + 4 = " + goal;
            if (4 + 4 / 4 - 4 == goal) return "4 + 4 / 4 - 4 = " + goal;
            if (4 + 4 / 4 * 4 == goal) return "4 + 4 / 4 * 4 = " + goal;
            if (4 + 4 / 4 / 4 == goal) return "4 + 4 / 4 / 4 = " + goal;
            if (4 - 4 + 4 + 4 == goal) return "4 - 4 + 4 - 4 = " + goal;
            if (4 - 4 + 4 - 4 == goal) return "4 - 4 + 4 - 4 = " + goal;
            if (4 - 4 + 4 * 4 == goal) return "4 - 4 + 4 * 4 = " + goal;
            if (4 - 4 + 4 / 4 == goal) return "4 - 4 + 4 / 4 = " + goal;
            if (4 - 4 - 4 + 4 == goal) return "4 - 4 - 4 + 4 = " + goal;
            if (4 - 4 - 4 - 4 == goal) return "4 - 4 - 4 - 4 = " + goal;
            if (4 - 4 - 4 * 4 == goal) return "4 - 4 - 4 * 4 = " + goal;
            if (4 - 4 - 4 / 4 == goal) return "4 - 4 - 4 / 4 = " + goal;
            if (4 - 4 * 4 + 4 == goal) return "4 - 4 * 4 + 4 = " + goal;
            if (4 - 4 * 4 - 4 == goal) return "4 - 4 * 4 - 4 = " + goal;
            if (4 - 4 * 4 * 4 == goal) return "4 - 4 * 4 * 4 = " + goal;
            if (4 - 4 * 4 / 4 == goal) return "4 - 4 * 4 / 4 = " + goal;
            if (4 - 4 / 4 + 4 == goal) return "4 - 4 / 4 + 4 = " + goal;
            if (4 - 4 / 4 - 4 == goal) return "4 - 4 / 4 - 4 = " + goal;
            if (4 - 4 / 4 * 4 == goal) return "4 - 4 / 4 * 4 = " + goal;
            if (4 - 4 / 4 / 4 == goal) return "4 - 4 / 4 / 4 = " + goal;
            if (4 * 4 + 4 + 4 == goal) return "4 * 4 + 4 - 4 = " + goal;
            if (4 * 4 + 4 - 4 == goal) return "4 * 4 + 4 - 4 = " + goal;
            if (4 * 4 + 4 * 4 == goal) return "4 * 4 + 4 * 4 = " + goal;
            if (4 * 4 + 4 / 4 == goal) return "4 * 4 + 4 / 4 = " + goal;
            if (4 * 4 - 4 + 4 == goal) return "4 * 4 - 4 + 4 = " + goal;
            if (4 * 4 - 4 - 4 == goal) return "4 * 4 - 4 - 4 = " + goal;
            if (4 * 4 - 4 * 4 == goal) return "4 * 4 - 4 * 4 = " + goal;
            if (4 * 4 - 4 / 4 == goal) return "4 * 4 - 4 / 4 = " + goal;
            if (4 * 4 * 4 + 4 == goal) return "4 * 4 * 4 + 4 = " + goal;
            if (4 * 4 * 4 - 4 == goal) return "4 * 4 * 4 - 4 = " + goal;
            if (4 * 4 * 4 * 4 == goal) return "4 * 4 * 4 * 4 = " + goal;
            if (4 * 4 * 4 / 4 == goal) return "4 * 4 * 4 / 4 = " + goal;
            if (4 * 4 / 4 + 4 == goal) return "4 * 4 / 4 + 4 = " + goal;
            if (4 * 4 / 4 - 4 == goal) return "4 * 4 / 4 - 4 = " + goal;
            if (4 * 4 / 4 * 4 == goal) return "4 * 4 / 4 * 4 = " + goal;
            if (4 * 4 / 4 / 4 == goal) return "4 * 4 / 4 / 4 = " + goal;
            if (4 / 4 + 4 + 4 == goal) return "4 / 4 + 4 - 4 = " + goal;
            if (4 / 4 + 4 - 4 == goal) return "4 / 4 + 4 - 4 = " + goal;
            if (4 / 4 + 4 * 4 == goal) return "4 / 4 + 4 * 4 = " + goal;
            if (4 / 4 + 4 / 4 == goal) return "4 / 4 + 4 / 4 = " + goal;
            if (4 / 4 - 4 + 4 == goal) return "4 / 4 - 4 + 4 = " + goal;
            if (4 / 4 - 4 - 4 == goal) return "4 / 4 - 4 - 4 = " + goal;
            if (4 / 4 - 4 * 4 == goal) return "4 / 4 - 4 * 4 = " + goal;
            if (4 / 4 - 4 / 4 == goal) return "4 / 4 - 4 / 4 = " + goal;
            if (4 / 4 * 4 + 4 == goal) return "4 / 4 * 4 + 4 = " + goal;
            if (4 / 4 * 4 - 4 == goal) return "4 / 4 * 4 - 4 = " + goal;
            if (4 / 4 * 4 * 4 == goal) return "4 / 4 * 4 * 4 = " + goal;
            if (4 / 4 * 4 / 4 == goal) return "4 / 4 * 4 / 4 = " + goal;
            if (4 / 4 / 4 + 4 == goal) return "4 / 4 / 4 + 4 = " + goal;
            if (4 / 4 / 4 - 4 == goal) return "4 / 4 / 4 - 4 = " + goal;
            if (4 / 4 / 4 * 4 == goal) return "4 / 4 / 4 * 4 = " + goal;
            if (4 / 4 / 4 / 4 == goal) return "4 / 4 / 4 / 4 = " + goal;
            return "no solution";
        }
    }
}