using System;

namespace Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");

            var articles = int.Parse(input[0]);
            var factor  = int.Parse(input[1]);

            var larger = 0;
            var smaller = 0;

            if (articles >= factor)
            {
                larger = articles;
                smaller = factor;
            }
            else
            {
                larger = factor;
                smaller = articles;
            }

            var scientists = 0;
            if (smaller > 1) scientists = larger * (smaller - 1) + 1;
            else scientists = larger * smaller;
            
            Console.WriteLine(scientists);
        }
    }
}