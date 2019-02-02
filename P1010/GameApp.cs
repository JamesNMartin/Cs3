//DATE          DEVELOPER          DESCRIPTION
//2019-01-27    jmsnmrtn           PROJECT CREATED, COMMITED, AND PUSHED (ALL CSx ASSIGNMENTS ARE PRIVATE REPOS)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 10.10 (Tic-Tac-Toe) Create class TicTacToe that will enable you to write a complete app to play the game of Tic-Tac-Toe. The class contains a private 3-by-3 rectangular array of integers. The constructor should initialize the empty board to all 0s. Allow two human players. Wherever the first player moves, place a 1 in the specified square, and place a 2 wherever the second player moves. Each move must be to an empty square. After each move, determine whether the game has been won and whether it’s a draw. For 10.10 only this first scenario is required.

If you feel ambitious, modify your app so that the computer makes the moves for one of the players. Also, allow the player to specify whether he or she wants to go first or second. P1010.cs will serve as the test driver for the TicTacToe class. If you feel exceptionally ambitious, develop an app that will play three-dimensional Tic-Tac-Toe on a 4-by-4-by-4 board.
*/

namespace TicTacToe
{
    class GameApp
    {
        private static int[,] board;

        static void Main(string[] args)
        {

            Console.WriteLine("Lets play Tic-Tac-Toe");
            GameApp game = new GameApp();
            PrintBoard();
            
        }
        static void PrintBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
        public GameApp()
        {
            board = new int[3, 3];
        }
    }
}
