using System;
using System.Collections.Generic;
using System.Linq;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ");
            var order = Console.ReadLine();

            var nubmerList = new List<int>();
            foreach (var c in numbers)
            {
                nubmerList.Add(int.Parse(c.ToString()));
            }
            
            nubmerList.Sort();
            var correctList = new List<int>();

            foreach (var c in order)
            {
                if (c == 'A') correctList.Add(nubmerList[0]);
                else if (c == 'B') correctList.Add(nubmerList[1]);
                else if (c == 'C') correctList.Add(nubmerList[2]);
            }

            var output = correctList[0].ToString() + " " + correctList[1].ToString() + " " + correctList[2].ToString();
            Console.WriteLine(output);
        }
    }
}