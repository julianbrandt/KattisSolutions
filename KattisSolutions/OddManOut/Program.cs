using System;
using System.Linq;

namespace OddManOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {
                var amount = int.Parse(Console.ReadLine());
                var people = Console.ReadLine().Split(" ").Select(n => int.Parse(n.ToString())).ToList();
                for (var j = 0; j < people.Count; j++)
                {
                    var obs = people[j];
                    people[j] = 0;
                    int? partner = people.IndexOf(obs);
                    if (partner != -1)
                    {
                        people[j] = obs;
                        continue;
                    }
                    Console.WriteLine("Case #" + (i+1) + ": " + obs);
                    break;
                }
            }
        }
    }
}