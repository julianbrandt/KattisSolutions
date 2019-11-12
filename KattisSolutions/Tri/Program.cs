using System;
using System.Linq;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var a = input[0];
            var b = input[1];
            var c = input[2];

            if (a + b == c)
            {
                Console.WriteLine(a + "+" + b + "=" + c);
            }
            else if (a - b == c)
            {
                Console.WriteLine(a + "-" + b + "=" + c);
            }
            else if (a / b == c)
            {
                Console.WriteLine(a + "/" + b + "=" + c);
            }
            else if (a * b == c)
            {
                Console.WriteLine(a + "*" + b + "=" + c);
            }
            else if (a == b + c)
            {
                Console.WriteLine(a + "=" + b + "+" + c);
            }
            else if (a == b - c)
            {
                Console.WriteLine(a + "=" + b + "-" + c);
            }
            else if (a == b / c)
            {
                Console.WriteLine(a + "=" + b + "/" + c);
            }
            else if (a == b * c)
            {
                Console.WriteLine(a + "=" + b + "*" + c);
            }
        }
    }
}