using System;
using System.Linq;

namespace PokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var numbers = input.Select(n => n[0]).ToList();
            numbers.Sort();
            
            var strength = 1;

            var runLength = 1;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    runLength++;
                    if (runLength > strength) strength = runLength;
                }
                else
                {
                    runLength = 1;
                }
            }
            Console.WriteLine(strength);
        }
    }
}