using System;

namespace HeartRate
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var line = Console.ReadLine().Split(" ");
                var beats = int.Parse(line[0]);
                var time = double.Parse(line[1]);

                var BPM = beats * 60 / time;
                var highABPM = 60.0 / (time / (beats+1));
                var lowABPM = 60.0 / (time / (beats - 1));
                
                Console.WriteLine($"{lowABPM} {BPM} {highABPM}");
            }
        }
    }
}