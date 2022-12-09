using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInCSharp
{
    class Program
    {
        static string[,] matrix =
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };
        static string[,] matrixposition =
        {
            {"00","01","02"},
            {"10","11","12"},
            {"20","21","22"}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("\n TIC TAC TO START\n");
            TicTacTo tic = new TicTacTo();
            tic.GetTicTacTo(); 
            
            

            Console.WriteLine("\n\nTIC TAC TO  END");
            Console.ReadLine();

            Console.Write("\n\n\n");


            bool Winner = Checker(matrix);
            if (Winner)
                Console.WriteLine("Winner");
            foreach (var item in matrix)
            {
                Console.Write(item + " ");
            }


            Console.Write("\n\n\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) % 2 != 0)
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine("\n");
            }


            ////////////////////////PRINTING DIGONAL
            int arrayLength = matrix.GetLength(0) - 1;
            Console.Write("\n\n\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j || (i + j == arrayLength))
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine("\n");
            }
            Console.Write("\n\n\n");

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.ReadLine();

        }
        public static bool Checker(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }
        public static void UpdatePosition(int pos,string pushvalue)
        {
            switch (pos)
            {
                case 1:
                    {
                        matrix[0, 0] = pushvalue;
                        break;
                    }
                case 2:
                    {
                        matrix[0, 2] = pushvalue;
                        break;
                    }

                case 3:
                    {
                        matrix[0, 2] = pushvalue;
                        break;
                    }
                case 4:
                    {
                        matrix[1, 0] = pushvalue;
                        break;
                    }
                case 5:
                    {
                        matrix[1, 1] = pushvalue;
                        break;
                    }
                case 6:
                    {
                        matrix[1, 2] = pushvalue;
                        break;
                    }
                case 7:
                    {
                        matrix[2, 0] = pushvalue;
                        break;
                    }
                case 8:
                    {
                        matrix[2, 1] = pushvalue;
                        break;
                    }
                case 9:
                    {
                        matrix[2, 2] = pushvalue;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ENTER VALUE IS OUT OF THE MATRIX!!");

                        break;
                    }

            }
            

        }
        public static void TicTacTo()
        {
            int Player = 1;
            string pushvalue = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" |  " + matrix[i, j]);
                }
                Console.Write(" |");
                Console.Write("\n |____|____|____|\n");
            }

            Console.WriteLine("Player {} Choose your feild :: ", Player);
            if (Player == 1)
            {
                pushvalue = "O";
                Player = 2;
            }
            else
            {
                Player = 1;
                pushvalue = "X";
            }

            if (int.TryParse(Console.ReadLine(), out int position))
            {
                UpdatePosition(position, pushvalue);

            }
            else
            {
                Console.WriteLine("Please enter any valid position!!!!!");
            }

        }
    }
}
