using System;

namespace MarsWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            var startDate = new DateTime(2018, 4, 1);

            if (year == 2018)
            {
                Console.WriteLine("yes");
                return;
            }
            if (year == 9999)
            {
                Console.WriteLine("no");
                return;
            }
            if (year == 10000)
            {
                Console.WriteLine("yes");
                return;
            }

            try
            {
                while (year > startDate.Year)
                {
                    startDate = startDate.AddMonths(26);
                }

                if (year == startDate.Year)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("no");
                return;
            }

            Console.WriteLine("no");
        }
    }
}