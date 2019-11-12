using System;

namespace EulersNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var e = 2.718281828459;

            double result = 0;
            var iteration = 0;
            while (iteration <= number)
            {
                result += 1.0 / factorial(iteration);
                iteration++;
                if (result.ToString().Length > 13 && Math.Abs(result - e) < Math.Pow(10, -12))
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            Console.WriteLine(result);
        }

        static long factorial(int number)
        {
            var result = 1;
            for (var i = 1; number <= i; i++)
            {
                result *= i;
            }
            return number;
        }
    }
}