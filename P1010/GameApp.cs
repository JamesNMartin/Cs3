//DATE          DEVELOPER          DESCRIPTION
//2019-01-27    jmsnmrtn           PROJECT CREATED, COMMITED, AND PUSHED (ALL CSx ASSIGNMENTS ARE PRIVATE REPOS)
//2019-2-2      jmsnmrtn           Added a header for the program for how to us. Also added comments to the code that I have so far.
//                                 Sadly due to poor time mangement and just general troubles with the code I wasnt able to finish. There is no check for winners.
//                                 There also is no check if the user trys to place their piece where there is already a piece. 

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
        private static bool playerOneTurn = false;
        //private static bool playerTwoTurn = false;

        static void Main(string[] args)
        {
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
  _______          ______               ______         
 /_  __(_)____    /_  __/___ ______    /_  __/___  ___ 
  / / / / ___/_____/ / / __ `/ ___/_____/ / / __ \/ _ \
 / / / / /__/_____/ / / /_/ / /__/_____/ / / /_/ /  __/
/_/ /_/\___/     /_/  \__,_/\___/     /_/  \____/\___/ 
                                                       
How to use:
This is a simple game of tic-tac-toe. To play you will need two
players. You will need to select the row and column seperately
for the location you wish to put your mark. The board is marked 
by 0's and 0's mean that the spot is empty. Player one is 
marked on the board by a 1 and player two is marked with a 2.
The range of values for the rows and columns are 0-2. Anything
outside of that will crash. (Sadly I ran out of time)
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
");
            Console.WriteLine("Lets play Tic-Tac-Toe!\n");
            GameApp game = new GameApp();
            while (true)
            {
                GameInProgress();
            }

        }
        public GameApp()
        {
            board = new int[3, 3];
            playerOneTurn = true;
            PrintBoard();
            Console.WriteLine("");

        }
        static void GameInProgress()
        {
            if (playerOneTurn == true)
            {
                PlayerOneMove();
            }
            else
            {
                PlayerTwoMove();
            }
        }
        static void PlayerOneMove()
        {
            Console.WriteLine("player one its your turn");
            Console.Write("Select row [0-2]: ");
            int userSelectRow = int.Parse(Console.ReadLine());
            Console.Write("Select column [0-2]: ");
            int userSelectColumn = int.Parse(Console.ReadLine());
            int playerOne = 1;
            PlayerMove(userSelectRow, userSelectColumn, playerOne);
            playerOneTurn = false;
            PrintBoard();

        }
        static void PlayerTwoMove()
        {
            Console.WriteLine("player two its your turn");
            Console.Write("select column [0-2]: ");
            int userSelectColumn = int.Parse(Console.ReadLine());
            Console.Write("select row [0-2]: ");
            int userSelectRow = int.Parse(Console.ReadLine());
            int playerTwo = 2;
            PlayerMove(userSelectRow, userSelectColumn, playerTwo);
            playerOneTurn = true;
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
        static void PlayerMove(int row, int col, int player)
        {
            if (player == 1)
            {
                board[row, col] = 1;
            }
            else
            {
                board[row, col] = 2;

            }
        }
    }
}
