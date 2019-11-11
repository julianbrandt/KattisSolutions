using System;
using System.Text;

namespace DetailedDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {
                var builder = new StringBuilder();

                var str1 = Console.ReadLine();
                var str2 = Console.ReadLine();

                for (var j = 0; j < str1.Length; j++)
                {
                    if (str1[j].Equals(str2[j]))
                        builder.Append(".");
                    else
                        builder.Append("*");
                }
                
                Console.WriteLine(str1);
                Console.WriteLine(str2);
                Console.WriteLine(builder.ToString());
                Console.WriteLine();
            }
        }
    }
}