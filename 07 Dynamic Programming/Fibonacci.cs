using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Dynamic_Programming
{
    class Fibonacci
    {
        //exponential time O(2^n)
        //slower than the iterative function
        //does a lot of repeated work
        //bad solution for finding a fib number
        public int Recursion(int n)
        {
            Console.Write("call n = " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");
            if (n < 2) return n;

            return Recursion(n - 1) + Recursion(n - 2);
        }

        //0(2n)
        //exponential time
        //became a lot faster
        //theoretically O(n) = O(2n)
        //top-down: memoization
        //store solutions along the way
        //store solutions in a lookup table (array)
        //comes from taking a memo
        public int Memoization(int n, int[] memoization)
        {
            Console.Write("call n = " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (memoization[n] != 0) return memoization[n];

            memoization[n] = Memoization(n - 1, memoization) + Memoization(n - 2, memoization);
            return memoization[n];
        }

        //linear space
        //linear time
        //bottom-up tabulation
        //start at the bottom, fill a lookup table from the start
        //start with the smalled item (sorting elements first)
        //run time is same as iterative solution
        public int Tabulation(int n)
        {

            if (n < 0) throw new Exception("Crazy input!");

            //build the table
            int[] tabulation = new int[n + 2];

            tabulation[0] = 0;
            tabulation[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                Console.Write("call n = " + i + " ");
                tabulation[i] = tabulation[i - 1] + tabulation[i - 2];
            }
            return tabulation[n];
        }

        //best case
        //linear time O(n)
        public int Iterative(int n)
        {
            if (n < 0) throw new Exception("Crazy input!");
            if (n < 2) return n;

            int fib = 0;
            int fib0 = 0;
            int fib1 = 1;

            for (int i = 2; i <= n; i++)
            {
                fib = fib0 + fib1;
                fib0 = fib1;
                fib1 = fib;
            }
            return fib;
        }
    }
}
