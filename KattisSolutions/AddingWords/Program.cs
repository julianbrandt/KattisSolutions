using System;
using System.Collections.Generic;
using System.Linq;

namespace AddingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, int>();
            
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var split = line.Split(" ");
                switch (split[0])
                {
                    case "def":
                        if (words.ContainsKey(split[1]))
                        {
                            words[split[1]] = int.Parse(split[2]);
                        }
                        else
                        {
                            words.Add(split[1], int.Parse(split[2]));
                        }
                        break;
                    case "calc":
                        var unsplit = line.Substring(5, line.Length - 5);
                        var expression = line.Substring(5, line.Length - 7).Split(" ");
                        var sum = 0;

                        for (var i = 0; i < expression.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (!words.ContainsKey(expression[i]))
                                {
                                    sum = int.MinValue;
                                }
                                else
                                {
                                    sum += words[expression[i]];
                                }
                            }

                            if (sum != int.MinValue)
                            {
                                switch (expression[i])
                                {
                                    case "+":
                                        if (!words.ContainsKey(expression[i + 1]))
                                        {
                                            sum = int.MinValue;
                                        }
                                        else
                                        {
                                            sum += words[expression[i + 1]];
                                            i++;
                                        }
                                        break;
                                    case "-":
                                        if (!words.ContainsKey(expression[i + 1]))
                                        {
                                            sum = int.MinValue;
                                        }
                                        else
                                        {
                                            sum -= words[expression[i + 1]];
                                            i++;
                                        }
                                        break;
                                }
                            }
                        }

                        if (words.ContainsValue(sum))
                        {
                            Console.WriteLine(unsplit + " " + words.FirstOrDefault(w => w.Value == sum).Key);   
                        }
                        else
                        {
                            Console.WriteLine(unsplit + " " + "unknown");
                        }
                        break;
                    
                    case "clear":
                        words = new Dictionary<string, int>();
                        break;
                }
            }
        }
    }
}