using System;

namespace ThreeDPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            var statues = int.Parse(Console.ReadLine());
            var printers = 1;
            var days = 0;
            var produced = 0;

            while (printers < (double) statues / 2.0)
            {
                printers *= 2;
                days++;
            }

            while (produced < statues)
            {
                produced += printers;
                days++;
            }
            Console.WriteLine(days);
        }
    }
}