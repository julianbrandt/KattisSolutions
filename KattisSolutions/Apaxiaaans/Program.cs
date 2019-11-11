using System;
using System.Collections.Generic;
using System.Linq;

namespace Apaxiaaans
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new List<char>();
            output.Add(input.ToCharArray()[0]);
            
            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] != output[output.Count-1]) output.Add(input[i]);
            }

            var outputString = output.Aggregate("", (current, c) => current + c);
            
            Console.WriteLine(outputString);
        }
    }
}