using System;

namespace Easiest
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "0")
            {
                var n = int.Parse(line);
                var sumN = sumOfDigits(n);

                for (var i = 11;; i++)
                {
                    if (sumOfDigits(i * n) == sumN)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }

        static int sumOfDigits(int input)
        {
            var sum = 0;
            var digits = input.ToString().ToCharArray();
            foreach (var digit in digits)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }
    }
}