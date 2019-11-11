using System;

namespace ANewAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = "";

            input = input.ToLower();
            foreach (var c in input)
            {
                switch (c)
                {
                    case 'a':
                        output += '@';
                        break;
                    case 'b':
                        output += '8';
                        break;
                    case 'c':
                        output += '(';
                        break;
                    case 'd':
                        output += "|)";
                        break;
                    case 'e':
                        output += '3';
                        break;
                    case 'f':
                        output += '#';
                        break;
                    case 'g':
                        output += '6';
                        break;
                    case 'h':
                        output += "[-]";
                        break;
                    case 'i':
                        output += '|';
                        break;
                    case 'j':
                        output += "_|";
                        break;
                    case 'k':
                        output += "|<";
                        break;
                    case 'l':
                        output += '1';
                        break;
                    case 'm':
                        output += @"[]\/[]";
                        break;
                    case 'n':
                        output += @"[]\[]";
                        break;
                    case 'o':
                        output += '0';
                        break;
                    case 'p':
                        output += "|D";
                        break;
                    case 'q':
                        output += "(,)";
                        break;
                    case 'r':
                        output += "|Z";
                        break;
                    case 's':
                        output += '$';
                        break;
                    case 't':
                        output += "']['";
                        break;
                    case 'u':
                        output += "|_|";
                        break;
                    case 'v':
                        output += @"\/";
                        break;
                    case 'w':
                        output += @"\/\/";
                        break;
                    case 'x':
                        output += "}{";
                        break;
                    case 'y':
                        output += "`/";
                        break;
                    case 'z':
                        output += '2';
                        break;
                    default:
                        output += c;
                        break;
                }
            }
            Console.WriteLine(output);
        }
    }
}