using System;

namespace Romans
{
    class Program
    {
        private static double paces(double d)
        {
            const double ratio = (5280.0 / 4854.0) * 1000.0;
            return Math.Round(d * ratio);
        }
        
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
             Console.WriteLine(paces(miles));
        }
    }
}