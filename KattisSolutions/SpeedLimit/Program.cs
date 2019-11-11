using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines;
            while ((lines = Console.ReadLine()) != "-1")
            {
                var lineCount = int.Parse(lines);
                var timeElapsed = 0;
                var milesDriven = 0;
                for (var i = 0; i < lineCount; i++)
                {
                    var line = Console.ReadLine().Split(" ");
                    milesDriven += int.Parse(line[0]) * (int.Parse(line[1]) - timeElapsed);
                    timeElapsed = int.Parse(line[1]);
                }
                Console.WriteLine(milesDriven + " miles");
            }
        }
    }
}