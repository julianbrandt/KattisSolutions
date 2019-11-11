using System;
using System.Linq;

namespace HarshadNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            while (true)
            {
                var input = number.ToString();
                var sum = input.Sum(c => int.Parse(c.ToString()));

                if (number % sum == 0)
                {
                    Console.WriteLine(number);
                    break;
                }
                number++;
            }
        }
    }
}