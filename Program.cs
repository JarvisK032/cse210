//Tic-Tac-Toe by Jarvis Kwong
using System;
using System.Collections.Generic;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> board = GetNewBoard();
            string currentPlayer = "X";

            while (!GameOver(board))
            {
                DisplayBoard(board);

                int choice = GetMoveChoice(currentPlayer);
                MakeMove(board, choice, currentPlayer);

                currentPlayer = Next(currentPlayer);
            }

            DisplayBoard(board);

            if (Win(board, "X"))
            {
                Console.WriteLine("X win");
            }
            else if (Win(board, "O"))
            {
                Console.WriteLine("O win");
            }
            else
            {
                Console.WriteLine("Draw");
            }

        }

        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static bool GameOver(List<string> board)
        {
            bool isGameOver = false;

            if (Win(board, "X") || Win(board, "O") || Tie(board))
            {
                isGameOver = true;
            }

            return isGameOver;
        }

        static bool Win(List<string> board, string player)
        {

            bool isWinner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                isWinner = true;
            }

            return isWinner; 
        }

        static bool Tie(List<string> board)
        {
            bool foundDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return !foundDigit;
        }

        static string Next(string currentPlayer)
        {
            string nextPlayer = "X";

            if (currentPlayer == "X")
            {
                nextPlayer = "O";
            }

            return nextPlayer;
        }

        static int GetMoveChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();

            int choice = int.Parse(move_string);
            return choice;
        }

        static void MakeMove(List<string> board, int choice, string currentPlayer)
        {
            int index = choice - 1;

            board[index] = currentPlayer;
        }
    }
}