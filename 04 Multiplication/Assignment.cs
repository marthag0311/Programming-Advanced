using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Multiplication
{
    internal class Assignment
    {
        public int Multiplication(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                return 0;
            }

            if (second < 0)
            {
                return -Multiplication(first, -second);
            }

            if (second > 1)
            {
                return first + Multiplication(first, second - 1);
            }

            return first;
        }
    }
}
