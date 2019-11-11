using System;

namespace AlphabetSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var whiteSpace = 0;
            var lowerCase = 0;
            var upperCase = 0;
            var symbol = 0;
            
            foreach (var c in input)
            {
                if (c >= 65 && c <= 90) upperCase++;
                else if (c >= 97 && c <= 122) lowerCase++;
                else if (c == '_') whiteSpace++;
                else if (c >= 33 && c <= 126) symbol++;
            }

            var whiteSpaceRatio = (double) whiteSpace / input.Length;
            var lowerCaseRatio = (double) lowerCase / input.Length;
            var upperCaseRatio = (double) upperCase / input.Length;
            var symbolRatio = (double) symbol / input.Length;
            
            Console.WriteLine(whiteSpaceRatio);
            Console.WriteLine(lowerCaseRatio);
            Console.WriteLine(upperCaseRatio);
            Console.WriteLine(symbolRatio);
        }
    }
}