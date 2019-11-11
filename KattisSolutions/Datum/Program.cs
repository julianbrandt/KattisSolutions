using System;

namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ");
            
            var dt = new DateTime(2009, int.Parse(line[1]), int.Parse(line[0]));
            
            Console.WriteLine(dt.DayOfWeek);
        }
    }
}