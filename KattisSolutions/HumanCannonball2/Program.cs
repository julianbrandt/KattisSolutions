using System;

namespace HumanCannonball2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {
                var line = Console.ReadLine().Split(" ");
                var initialVelocity = double.Parse(line[0]);
                var angle = double.Parse(line[1]);
                var distance = double.Parse(line[2]);
                var lowerHeight = double.Parse(line[3]);
                var upperHeight = double.Parse(line[4]);

                var t = distance / (initialVelocity * Math.Cos((angle / 180) * Math.PI));
                var height = initialVelocity * t * Math.Sin((angle) / 180 * Math.PI) - 0.5 * 9.81 * Math.Pow(t, 2);
                if (height > lowerHeight + 1 && height < upperHeight - 1)
                    Console.WriteLine("Safe");
                else
                    Console.WriteLine("Not Safe");
            }
        }
    }
}