using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sorting_Principles_Algorithms_Applications
{
    internal class Sorting
    {
        // Bubble Sort
        //Scan the array, swapping adjacent pair of elements if they are not in  order. This bubbles up the largest element to the end.
        //Scan the array again, bubbling up the second largest element.
        //etc...repeat until all elements are sorted    

        public string BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temporay = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporay;
                    }    
                }
            }
            return string.Join(" ", array);
        }
                
        internal string SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int smallest = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                int temporary = array[i];
                array[i] = array[smallest];
                array[smallest] = temporary;
            }
            return string.Join(" ", array);
        }

        internal string InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int tmp = array[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (array[j - 1] < tmp) break;
                    array[j] = array[j - 1];
                }
                array[j] = tmp;
            }
            return string.Join(" ", array);
        }
    }
}