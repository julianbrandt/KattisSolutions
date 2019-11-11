using System;
using System.Collections.Generic;
using System.Text;

namespace EnteringTheTime
{
    class Program
    {
        private static List<string> stateChanges = new List<string>();

        static void Main(string[] args)
        {
            var start = Console.ReadLine();
            stateChanges.Add(start);
            var end = Console.ReadLine();

            var currentPosition = int.Parse(stateChanges[stateChanges.Count-1][4].ToString());
            var direction = findDirectionMinOnes(currentPosition, int.Parse(end[4].ToString()));
            while (!stateChanges[stateChanges.Count-1][4].Equals(end[4]))
            {
                currentPosition = changeMinOnes(currentPosition, direction);
                var newStateChange = new StringBuilder();
                newStateChange.Append(stateChanges[stateChanges.Count-1].Substring(0, 4));
                newStateChange.Append(currentPosition);
                stateChanges.Add(newStateChange.ToString());
            }
            currentPosition = int.Parse(stateChanges[stateChanges.Count-1][3].ToString());
            direction = findDirectionMinTens(currentPosition, int.Parse(end[3].ToString()));
            while (!stateChanges[stateChanges.Count-1][3].Equals(end[3]))
            {
                currentPosition = changeMinTens(currentPosition, direction);
                var newStateChange = new StringBuilder();
                newStateChange.Append(stateChanges[stateChanges.Count-1].Substring(0, 3));
                newStateChange.Append(currentPosition);
                newStateChange.Append(stateChanges[stateChanges.Count-1][4]);
                stateChanges.Add(newStateChange.ToString());
            }

            if (stateChanges[stateChanges.Count - 1][0] == '2' && int.Parse(end[1].ToString()) > 3)
            {
                currentPosition = int.Parse(stateChanges[stateChanges.Count - 1][0].ToString());
                direction = findDirectionHourTens(currentPosition, int.Parse(end[0].ToString()));
                while (!stateChanges[stateChanges.Count - 1][0].Equals(end[0]))
                {
                    currentPosition = changeHourTens(currentPosition, direction);
                    var newStateChange = new StringBuilder();
                    newStateChange.Append(currentPosition);
                    newStateChange.Append(stateChanges[stateChanges.Count - 1].Substring(1, 4));
                    stateChanges.Add(newStateChange.ToString());
                }
                currentPosition = int.Parse(stateChanges[stateChanges.Count - 1][1].ToString());
                direction = findDirectionHourOnes(currentPosition, int.Parse(end[1].ToString()));
                while (!stateChanges[stateChanges.Count - 1][1].Equals(end[1]))
                {
                    currentPosition = changeHourOnes(currentPosition, direction);
                    var newStateChange = new StringBuilder();
                    newStateChange.Append(stateChanges[stateChanges.Count - 1][0]);
                    newStateChange.Append(currentPosition);
                    newStateChange.Append(stateChanges[stateChanges.Count - 1].Substring(2, 3));
                    stateChanges.Add(newStateChange.ToString());
                }
            }
            else
            {
                currentPosition = int.Parse(stateChanges[stateChanges.Count - 1][1].ToString());
                direction = findDirectionHourOnes(currentPosition, int.Parse(end[1].ToString()));
                while (!stateChanges[stateChanges.Count - 1][1].Equals(end[1]))
                {
                    currentPosition = changeHourOnes(currentPosition, direction);
                    var newStateChange = new StringBuilder();
                    newStateChange.Append(stateChanges[stateChanges.Count - 1][0]);
                    newStateChange.Append(currentPosition);
                    newStateChange.Append(stateChanges[stateChanges.Count - 1].Substring(2, 3));
                    stateChanges.Add(newStateChange.ToString());
                }

                currentPosition = int.Parse(stateChanges[stateChanges.Count - 1][0].ToString());
                direction = findDirectionHourTens(currentPosition, int.Parse(end[0].ToString()));
                while (!stateChanges[stateChanges.Count - 1][0].Equals(end[0]))
                {
                    currentPosition = changeHourTens(currentPosition, direction);
                    var newStateChange = new StringBuilder();
                    newStateChange.Append(currentPosition);
                    newStateChange.Append(stateChanges[stateChanges.Count - 1].Substring(1, 4));
                    stateChanges.Add(newStateChange.ToString());
                }
            }

            Console.WriteLine(stateChanges.Count);
            foreach (var state in stateChanges)
            {
                Console.WriteLine(state);
            }
        }

        private static bool findDirectionMinOnes(int start, int end)
        {
            var positiveSteps = 0;
            var negativeSteps = 0;
            var positiveCounter = start;
            var negativeCounter = start;
            while (negativeCounter != end)
            {
                negativeCounter = changeMinOnes(negativeCounter, false);
                negativeSteps++;
            }
            while (positiveCounter != end)
            {
                positiveCounter = changeMinOnes(positiveCounter, true);
                positiveSteps++;
            }

            return negativeSteps > positiveSteps;
        }
        
        private static bool findDirectionMinTens(int start, int end)
        {
            return start < end;
        }
        
        private static bool findDirectionHourOnes(int start, int end)
        {
            if (stateChanges[stateChanges.Count - 1][0] == '2') return start < end;
            
            var positiveSteps = 0;
            var negativeSteps = 0;
            var positiveCounter = start;
            var negativeCounter = start;
            while (negativeCounter != end)
            {
                negativeCounter = changeHourOnes(negativeCounter, false);
                negativeSteps++;
            }
            while (positiveCounter != end)
            {
                positiveCounter = changeHourOnes(positiveCounter, true);
                positiveSteps++;
            }

            return negativeSteps > positiveSteps;
        }
        
        private static bool findDirectionHourTens(int start, int end)
        {
            return start < end;
        }
        
        private static int changeMinOnes(int number, bool direction)
        {
            if (direction)
            {
                number++;
                if (number == 10) number = 0;
            }
            else
            {
                number--;
                if (number == -1) number = 9;
            }

            return number;
        }
        
        private static int changeMinTens(int number, bool direction)
        {
            if (direction)
            {
                number++;
            }
            else
            {
                number--;
            }

            return number;
        }
        
        private static int changeHourOnes(int number, bool direction)
        {
            if (direction)
            {
                number++;
                if (number == 10) number = 0;
            }
            else
            {
                number--;
                if (number == -1) number = 9;
            }

            return number;
        }
        
        private static int changeHourTens(int number, bool direction)
        {
            if (direction)
            {
                number++;
            }
            else
            {
                number--;
            }

            return number;
        }
    }
}