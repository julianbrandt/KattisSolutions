using System;
using System.Linq;

namespace APrizeNoOneCanWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = Console.ReadLine().Split(" ");
            var items = int.Parse(options[0]);
            var price = int.Parse(options[1]);
            var prices = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            
            prices.Sort();

            var amount = 0;
            for (var i = 1; i < items; i++)
            {
                if (prices[i] + prices[i-1] <= price)
                {
                    amount = i;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(amount+1);
        }
    }
}