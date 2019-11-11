using System;

namespace ADifferentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var values = line.Split(" ");
                var i1 = Int64.Parse(values[0]);
                var i2 = Int64.Parse(values[1]);

                if (i1 < i2)
                {
                    Console.WriteLine(i2 - i1);
                }
                else
                {
                    Console.WriteLine(i1 - i2);
                }
            }
        }
    }
}