using System;
using System.Collections.Generic;

namespace Akcija
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var prices = new List<int>();
            var price = 0;

            for (var i = 0; i < lines; i++)
            {
                prices.Add(int.Parse(Console.ReadLine()));
            }
            
            prices.Sort((i1, i2) => i2.CompareTo(i1));
            
            for (var i = 0; i < lines; i++)
            {
                if ((i + 1) % 3 != 0)
                {
                    price += prices[i];
                }
            }
            
            Console.WriteLine(price);
        }
    }
}