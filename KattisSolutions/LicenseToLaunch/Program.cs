using System;
using System.Linq;

namespace LicenseToLaunch
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = Console.ReadLine();
            var debris = Console.ReadLine().Split(" ").Select(n => int.Parse(n)).ToList();

            var lowestDebris = debris.IndexOf(debris.Min());
            
            Console.WriteLine(lowestDebris);
        }
    }
}