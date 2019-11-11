using System;

namespace LastFactorialDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (var i = 0; i < lines; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var factorial = n;

                for (var j = n-1; j > 0; j--)
                {
                    factorial *= j;
                }
                
                Console.WriteLine(factorial.ToString()[factorial.ToString().Length - 1]);
            }
        }
    }
}