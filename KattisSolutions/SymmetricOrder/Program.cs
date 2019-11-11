using System;

namespace SymmetricOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines;
            var set = 0;
            while ((lines = int.Parse(Console.ReadLine())) != 0)
            {
                set++;
                Console.WriteLine("SET " + set);
                for (var i = 0; i < lines; i++)
                {
                    Console.WriteLine(Console.ReadLine());
                }
            }
        }
    }
}