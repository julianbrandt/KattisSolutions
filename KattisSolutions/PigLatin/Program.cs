using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var words = line.Split(" ");

                for (var i = 0; i < words.Length; i++)
                {
                    if (isVowel(words[i][0]))
                    {
                        words[i] += "yay";
                    }
                    else
                    {
                        var firstVowel = 0;
                        for (var j = 0; j < words[i].Length; j++)
                        {
                            if (isVowel(words[i][j]))
                            {
                                firstVowel = j;
                                break;
                            }
                        }

                        words[i] = words[i].Substring(firstVowel, words[i].Length - (firstVowel)) +
                                   words[i].Substring(0, firstVowel) + "ay";
                    }
                }
                Console.WriteLine(String.Join(" ", words));
            }
        }

        static bool isVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c =='y';
        }
    }
}