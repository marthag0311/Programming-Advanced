using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Search___Intro_Big_O
{
    internal class Searching
    {
        public int count { get; set; }

        // Linear search
        public int Linear(int[] array, int number)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                if (array[i] == number)
                {
                    return i; //target found at index i
                }
            }
            return -1; //target not found
        }

        // Stupid search 
        public int Stupid(int[] array, int number)
        {
            count = 0;
            int max_count = array.Length * 2;

            Random random = new Random();

            while (count < max_count)
            {
                count++;

                int index = random.Next(0, array.Length);

                if (array[index] == number)
                {
                    return index; 
                }
            }
            return -1;            
        }

        // Binary search

        public int Binary(int[] array, int number)
        {
            count = 0;
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                count++;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number < array[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
