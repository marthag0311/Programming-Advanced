using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Recursion
{
    class Exercises
    {
        public int Sum(int n)
        {
            if (n <= 0) return 0;

            return n + Sum(n - 1);
        }

        public int Digits(int n)
        {
            if (n < 10) return 1;
                        
            return 1 + Digits(n / 10);
        }

        public string Reverse(string word)
        {
            if (word.Length == 1) reutrn word;

            //return Reverse(word.Substring(1, word.Length - 1)) + word[0];
            return word[word.Length - 1] + Reverse(word.Substring(0, word.Length - 1));
        }
    }
}
