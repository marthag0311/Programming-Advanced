using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sorting_Principles__Algorithms___Applications
{
    internal class Sorting
    {
        // Bubble Sort
        //Scan the array, swapping adjacent pair of elements if they are not in  order. This bubbles up the largest element to the end.
        //Scan the array again, bubbling up the second largest element.
        //etc...repeat until all elements are sorted

        public void Bubble(int[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    array[i] == array[i + 1];
                    array[i + 1] == array[i];
                }
            }
        }
    }
}
