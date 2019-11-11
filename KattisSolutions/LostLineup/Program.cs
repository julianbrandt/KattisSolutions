using System;
using System.Collections.Generic;
using System.Linq;

namespace LostLineup
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var originalLine = new int[people-1];
            var stringLine = Console.ReadLine().Split(" ");
            
            for (var i = 0; i < people-1; i++)
            {
                originalLine[i] = int.Parse(stringLine[i].ToString());
            }

            var sortedLine = new List<int>(originalLine).ToArray();
            Array.Sort(sortedLine);

            var orderList = new List<int> {-1};


            for (var i = 0; i < originalLine.Length; i++)
            {
                orderList.Add(Array.IndexOf(originalLine, sortedLine[i]));
            }
            
            var orderStringList = from i in orderList select (i + 2).ToString();

            Console.WriteLine(string.Join(" ",orderStringList.ToArray()));
        }
    }
}