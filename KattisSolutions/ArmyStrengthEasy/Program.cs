using System;
using System.Collections.Generic;
using System.Linq;

namespace ArmyStrengthEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());

            for (var i = 0; i < cases; i++)
            {
                Console.ReadLine();
                var armies = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                var unlinkedGodzillaArmy = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                var unlinkedMechaGodzillaArmy = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                unlinkedGodzillaArmy.Sort();
                unlinkedMechaGodzillaArmy.Sort();
                var godzillaArmy = new LinkedList<int>(unlinkedGodzillaArmy);
                var mechaGodzillaArmy = new LinkedList<int>(unlinkedMechaGodzillaArmy);

                while (godzillaArmy.Count > 0 && mechaGodzillaArmy.Count > 0)
                {
                    if (godzillaArmy.First.Value >= mechaGodzillaArmy.First.Value)
                    {
                        mechaGodzillaArmy.Remove(mechaGodzillaArmy.First.Value);
                    }
                    else
                    {
                        godzillaArmy.Remove(godzillaArmy.First.Value);
                    }
                }

                if (godzillaArmy.Count == 0)
                {
                    Console.WriteLine("MechaGodzilla");
                }
                else
                {
                    Console.WriteLine("Godzilla");
                }
            }
        }
    }
}