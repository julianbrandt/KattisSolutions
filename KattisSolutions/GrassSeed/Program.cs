using System;

namespace GrassSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var cost = double.Parse(Console.ReadLine());
            var lines = int.Parse(Console.ReadLine());
            
            double price = 0;
            
            for (var i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split(" ");

                var w = double.Parse(line[0].ToString());
                var l = double.Parse(line[1].ToString());

                var size = w * l;
                price += size * cost;
            }
            
            Console.WriteLine(price);
        }
    }
}