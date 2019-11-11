using System;

namespace PieceOfCake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");

            var size = Int32.Parse(input[0]);
            var h = Int32.Parse(input[1]);
            var v = Int32.Parse(input[2]);

            var largest = Math.Max(h, size - h) * Math.Max(v, size - v);
            
            Console.WriteLine(largest * 4);
        }
    }
}