using System;
using System.Linq;

namespace JudgingMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Select(n => int.Parse(n.ToString())).ToList();

            var max = input.IndexOf(input.Max());
            if (input[max] == 0)
            {
                Console.WriteLine("Not a moose");
                return;
            }

            string oddEven = "";
            if (input[input.Count - 1 - max] == input[max]) oddEven = "Even ";
            else oddEven = "Odd ";
            
            Console.WriteLine(oddEven + (input[max] * 2));
        }
    }
}