using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class GameBoard
    {
        /// <summary>
        /// Draws the field along with the actions of the players
        /// </summary>
        /// <param name="actions">Actions taken by the players on the field</param>
        /// <param name="playerSymbol">Symbol showing the player's turn</param>
        public static void PrintField(char[,] actions, char playerSymbol)
        {
            Console.WriteLine(" +" + string.Concat(Enumerable.Repeat("---+", 3)));

            for (int y = 2; y >= 0; y--)
            {
                Console.Write($"{y + 1}|"); //Y grid
                for (int x = 0; x < 3; x++)
                {
                    Console.Write($" {actions[y, x]} |");
                }
                Console.WriteLine("\n +" + string.Concat(Enumerable.Repeat("---+", 3)));
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"   {i + 1}"); //X grid
            }
            Console.WriteLine($"\nIt's {playerSymbol} turn:");
        }

        /// <summary>
        /// Looks for a winning combination on the board
        /// </summary>
        /// <param name="actions">Actions taken by the players on the field</param>
        /// <param name="playerSymbol">Symbol of the current player</param>
        /// <returns>true - if found, and false - if not</returns>
        public static bool FindWin(char[,] actions, char playerSymbol)
        {
            if ((actions[0, 0] == actions[0, 1] && actions[0, 1] == actions[0, 2] && actions[0, 0] == playerSymbol)
                || (actions[1, 0] == actions[1, 1] && actions[1, 1] == actions[1, 2] && actions[1, 0] == playerSymbol)
                || (actions[2, 0] == actions[2, 1] && actions[2, 1] == actions[2, 2] && actions[2, 0] == playerSymbol)

                || (actions[0, 0] == actions[1, 0] && actions[1, 0] == actions[2, 0] && actions[0, 0] == playerSymbol)
                || (actions[0, 1] == actions[1, 1] && actions[1, 1] == actions[2, 1] && actions[0, 1] == playerSymbol)
                || (actions[0, 2] == actions[1, 2] && actions[1, 2] == actions[2, 2] && actions[0, 2] == playerSymbol)

                || (actions[0, 0] == actions[1, 1] && actions[1, 1] == actions[2, 2] && actions[0, 0] == playerSymbol)
                || (actions[2, 0] == actions[1, 1] && actions[1, 1] == actions[0, 2]) && actions[2, 0] == playerSymbol)
            {
                return true;
            }
            return false;
        }
    }
}
