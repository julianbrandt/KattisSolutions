using System;
using System.Linq;

namespace ThisAintYourGrandpasCheckerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var board = new char[size][];
            for (var i = 0; i < size; i++)
            {
                board[i] = new char[size];
                var line = Console.ReadLine().ToCharArray();
                for (var j = 0; j < line.Length; j++)
                {
                    board[i][j] = line[j];
                }
            }

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size-2; j++)
                {
                    if (board[i][j].Equals(board[i][j + 1]) && board[i][j].Equals(board[i][j + 2]))
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }
                
                for (var j = 0; j < size-2; j++)
                {
                    if (board[j][i].Equals(board[j+1][i]) && board[j][i].Equals(board[j+2][i]))
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }

                var blacks = 0;
                var whites = 0;
                for (var j = 0; j < size; j++)
                {
                    if (board[i][j].Equals('W'))
                        whites++;
                    else
                        blacks++;
                }

                if (blacks != whites)
                {
                    Console.WriteLine(0);
                    return;
                }
                
                blacks = 0;
                whites = 0;
                for (var j = 0; j < size; j++)
                {
                    if (board[j][i].Equals('W'))
                        whites++;
                    else
                        blacks++;
                }

                if (blacks != whites)
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }
    }
}