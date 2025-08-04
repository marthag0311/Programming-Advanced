using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Largest_Bits
{
    class Assignment
    {
        public string Binary(int number)
        {
            if (number == 0) return '';

            int remainder = number % 2;

            string binary = Binary(number / 2) + remainder;

            return ;
        }
            
        public int LongestPalindromicSubSequence()
        {

        }
    }
}
