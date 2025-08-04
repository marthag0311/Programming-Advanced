using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Backtracking
{
    class NQueens
    {
        char[,] board; // 2d coz it's a square
        int size;
        public NQueens(int length)
        {
            size = length;
            board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        public bool PlaceQueens(int column)
        {
            //base case
            if (column == size)
            {
                return true;
            }

            //check all rows in the current column
            for (int row = 0; row < size; row++)
            {
                if (isSafe(row, column))
                {
                    board[row, column] = 'Q';
                    if (PlaceQueens(column + 1)) return true;
                    board[row, column] = '-';
                }
            }

            return false;
        }

        private bool isSafe(int row, int column)
        {
            //checking row left side;
            for (int i = 0; i < column; column++)
            {
                if (board[row, i] == 'Q')
                {
                    return false;
                }
            }

            //check upper diagonal
            for (int i = row, j = column; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 'Q')
                {
                    return false;
                }
            }

            //check lower diagonal
            for (int i = row, j = column; i < size && j >= 0; i++, j--)
            {
                if (board[i, j] == 'Q')
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    s += board[i, j] + " ";
                }
                s += "\n";
            }

            return s;
        }
    }
}