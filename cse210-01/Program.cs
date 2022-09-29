//Tic-Tac-Toe by Jarvis Kwong
using System;

namespace Test
{
    public class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice; 
        static int flag = 0;

        public static void Main(string[] args)
        {
            do
            {
                Board();
                if (player % 2 == 0)
                {
                    Console.WriteLine("O's turn to choose a square (1-9): ");
                }
                else
                {
                    Console.WriteLine("X's turn to choose a square (1-9): ");
                }
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Board();
            if (flag == 1)
            {   
                if(player % 2 + 1 == 1)
                {
                Console.WriteLine("X's won");
                Console.WriteLine("Good game. Thanks for playing!");
                }
                else
                {
                Console.WriteLine("O's won");
                Console.WriteLine("Good game. Thanks for playing!");
                }
            }              
            else
            {
                Console.WriteLine("Draw");
                Console.WriteLine("Good game. Thanks for playing!"); 
            }
        }
        private static void Board()
        {

            Console.WriteLine("{0}|{1}|{2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("-+-+-");
            Console.WriteLine("{0}|{1}|{2}", arr[7], arr[8], arr[9]);
        }
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}