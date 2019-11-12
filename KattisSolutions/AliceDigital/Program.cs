using System;
using System.Linq;

namespace AliceDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var options = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                var numberOfElements = options[0];
                var minimum = options[1];
                var elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                var obsStart = 0;
                var obsEnd = 0;
                var bestSum = 0;

                for (var j = 0; j < numberOfElements; j++)
                {
                    if (elements[j] == minimum)
                    {
                        if (j == 0)
                        {
                            obsStart = j;
                        }
                        else
                        {
                            obsStart = j - 1;
                            while (obsStart > 0)
                            {
                                if (elements[obsStart] <= minimum)
                                {
                                    obsStart++;
                                    break;
                                }
                                else if (obsStart > 0)
                                {
                                    obsStart--;
                                }
                            }
                        }

                        if (j == numberOfElements - 1)
                        {
                            obsEnd = j;
                        }
                        else
                        {
                            obsEnd = j + 1;
                            while (obsEnd < numberOfElements)
                            {
                                if (elements[obsEnd] <= minimum)
                                {
                                    break;
                                }
                                else if (obsEnd < numberOfElements)
                                {
                                    obsEnd++;
                                }
                            }
                        }

                        var sublist = elements.GetRange(obsStart, obsEnd - obsStart);
                        var sum = sublist.Sum();

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                    }
                }
                
                Console.WriteLine(bestSum);
            }
        }
    }
}