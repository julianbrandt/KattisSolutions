using System;

namespace HangingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var limit = int.Parse(input[0]);
            var lines = int.Parse(input[1]);

            var peopleOnTerrace = 0;
            var groupsDenied = 0;

            for (var i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split(" ");
                var numberOfPeople = int.Parse(line[1]);
                if (line[0].Equals("enter"))
                {
                    if (peopleOnTerrace + numberOfPeople > limit) groupsDenied++;
                    else peopleOnTerrace += numberOfPeople;
                }
                else if (line[0].Equals("leave")) peopleOnTerrace -= numberOfPeople;
            }
            
            Console.WriteLine(groupsDenied);
        }
    }
}