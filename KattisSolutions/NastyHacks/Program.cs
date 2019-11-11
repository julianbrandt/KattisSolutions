using System;

namespace NastyHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split(" ");

                var r = Int32.Parse(line[0]);
                var e = Int32.Parse(line[1]);
                var c = Int32.Parse(line[2]);

                if (r > e - c)
                {
                    Console.WriteLine("do not advertise");
                }
                else if (r < e - c)
                {
                    Console.WriteLine("advertise");
                }
                else
                {
                    Console.WriteLine("does not matter");
                }
            }
        }
    }
}