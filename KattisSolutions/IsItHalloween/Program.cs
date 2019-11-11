using System;

namespace IsItHalloween
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var month = input[0];
            var day = input[1];
            
            if (month.Equals("OCT") && day.Equals("31") || month.Equals("DEC") && day.Equals("25"))
                Console.WriteLine("yup");
            else
                Console.WriteLine("nope");
        }
    }
}