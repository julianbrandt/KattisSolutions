using System;

namespace Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var size = 2;

            for (var i = 1; i <= input; i++)
            {
                size = size * 2 - 1;
            }
            
            Console.WriteLine(Math.Pow(size, 2));
        }
    }
}