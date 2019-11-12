using System;
using System.Linq;

namespace AnthonyAndDiablo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            var size = input[0];
            var fence = input[1];
            
            if (areaOfCircle(fence) > size) Console.WriteLine("Diablo is happy!");
            else Console.WriteLine("Need more materials!");
        }
        
        static double areaOfCircle(double fence)
        {
            var radius = fence / Math.PI / 2;
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}