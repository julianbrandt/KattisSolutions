using System;
using System.Text;

namespace Kemija
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var builder = new StringBuilder();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    i += 2;
                }

                builder.Append(input[i]);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}