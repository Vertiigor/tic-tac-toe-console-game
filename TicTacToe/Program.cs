using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] actions = new char[3, 3];
            char playerSymbol;

            int inputX, inputY;

            for (int i = 0; i != 9; i++)
            {
                playerSymbol = i % 2 == 0 ? 'X' : 'O';

                Console.Clear();

                GameBoard.PrintField(actions, playerSymbol);

                while (true)
                {
                    Console.Write("X - "); inputX = int.Parse(Console.ReadLine());
                    Console.Write("Y - "); inputY = int.Parse(Console.ReadLine());

                    if (inputX <= 3 && inputY <= 3 && actions[inputY - 1, inputX - 1] == '\0')
                    {
                        break;
                    }

                    Console.WriteLine("This field is busy or you entered too large a number (check it)! Enter again: ");
                }

                actions[inputY - 1, inputX - 1] = playerSymbol;

                if (GameBoard.FindWin(actions, playerSymbol))
                {
                    Console.WriteLine($"Player {playerSymbol} has won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nobody won...");
                }
            }
            Console.WriteLine("Thanks for playing :)");
            Console.ReadKey();
        }

    }
}
