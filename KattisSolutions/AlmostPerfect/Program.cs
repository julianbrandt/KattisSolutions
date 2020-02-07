using System;
using System.Collections.Generic;
using System.Linq;

namespace AlmostPerfect
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var number = int.Parse(line);
                var divisors = new List<int>();

                for (var i = 1; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        if (number / i == i)
                        {
                            divisors.Add(i);
                        }
                        else
                        {
                            divisors.Add(i);
                            divisors.Add(number / i);
                        }
                    }
                }

                if (divisors.Contains(number)) divisors.Remove(number);
                
                var sum = divisors.Sum(x => x);
                if (sum == number)
                {
                    Console.WriteLine(number + " perfect");
                }
                else if (Math.Abs(sum - number) <= 2)
                {
                    Console.WriteLine(number + " almost perfect");
                }
                else
                {
                    Console.WriteLine(number + " not perfect");
                }
            }
        }
    }
}