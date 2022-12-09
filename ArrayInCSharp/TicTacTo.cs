using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInCSharp
{
    class TicTacTo
    {
        public string[,] matrix =
       {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };
        int Player=1;

        public void GetTicTacTo()
        {
            string pushvalue = "";
            Console.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i==0 && j==0)
                    {
                        Console.WriteLine(" _______________");
                    }
                    Console.Write(" |  " + matrix[i, j]);
                }
                Console.Write(" |");
                Console.Write("\n |____|____|____|\n");
            }

            bool result = CheckResult(matrix);
            if (result)
                return;

            

            Console.Write("\n\nPlayer {0} Choose your field :: ", Player);
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
                Console.WriteLine("PLEASE ENTER ANY VALID POSITION!!!");
                GetTicTacTo();
            }

        }
        public void UpdatePosition(int pos, string pushvalue)
        {
            switch (pos)
            {
                case 1:
                    {
                        matrix[0, 0] = pushvalue;
                        GetTicTacTo();
                        break;
                    }
                case 2:
                    {
                        matrix[0, 1] = pushvalue;
                        GetTicTacTo();
                        break;
                    }
                case 3:
                    {
                        matrix[0, 2] = pushvalue;
                        GetTicTacTo();
                        break;
                    }
                case 4:
                    {
                        matrix[1, 0] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                case 5:
                    {
                        matrix[1, 1] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                case 6:
                    {
                        matrix[1, 2] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                case 7:
                    {
                        matrix[2, 0] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                case 8:
                    {
                        matrix[2, 1] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                case 9:
                    {
                        matrix[2, 2] = pushvalue;
                        GetTicTacTo(); 
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ENTER VALUE IS OUT OF THE MATRIX!!");
                        GetTicTacTo(); 
                        break;
                    }
            }
        }
        public bool CheckResult(string[,] board)
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
    }
}
