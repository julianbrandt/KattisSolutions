using System;

namespace QALY
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            var qaly = 0.0;

            for (var i = 0; i < lines; i++)
            {
                var period = Console.ReadLine().Split(" ");

                qaly += double.Parse(period[0]) * double.Parse(period[1]);
            }
            
            Console.WriteLine(qaly);
        }
    }
}