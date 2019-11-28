using System;

namespace SumSquaredDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            for (var i = 1; i <= cases; i++)
            {
                var line = Console.ReadLine().Split(" ");
                var b = int.Parse(line[1]);
                var a = int.Parse(line[2]);

                var n = Convert.ToString(a);
                var charArray = n.ToCharArray();
                Array.Reverse(charArray);
                n = new String(charArray);
                
                var sum = 0;
                foreach (var c in n.ToCharArray())
                {
                    Console.WriteLine(c);
                    sum += (int) Math.Pow(int.Parse(c.ToString()), 2);
                }
                
                Console.WriteLine($"{i} {sum}");
            }
        }
    }
}