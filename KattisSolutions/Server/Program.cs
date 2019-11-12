using System;
using System.Linq;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var tasks = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            var done = 0;
            var timeSpent = 0;
            foreach (var task in tasks)
            {
                if (timeSpent + task <= options[1])
                {
                    timeSpent += task;
                    done++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(done);
        }
    }
}