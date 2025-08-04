using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _02_Sorting_Principles_Algorithms_Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 32, 7, 45, 23, 41, 19, 28, 50, 1, 37 };
            
            Sorting sorting = new Sorting();

            //Console.WriteLine(sorting.BubbleSort(array));
            //Console.WriteLine(sorting.SelectionSort(array));
            Console.WriteLine(sorting.InsertionSort(array));

            // Bubble Sort
            //Scan the array, swapping adjacent pair of elements
            //if they are not in  order. This bubbles up the
            //largest element to the end.
            //Scan the array again, bubbling up the second largest element.
            //etc...repeat until all elements are sorted

            //32 7 45 23 41 19 28 50 1 37
            //7 32 23 41 19 28 45 1 37 50
            //7 23 32 19 28 41 1 37 45 50
            //7 23 19 28 32 1 37 41 45 50
            // 7 19 23 28 1 32 37 41 45 50
            //7 19 23 1 28 32 37 41 45 50
            //7 19 1 23 28 32 37 41 45 50
            //7 1 19 23 28 32 37 41 45 50
            //1 7 19 23 28 32 37 41 45 50
            //1 7 19 23 28 32 37 41 45 50


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Or 

            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++) //excluding the bubbled largest elements at the end
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            /*Console.Write("Bubble Sort: ");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/

            // Selection Sort 
            //Find the smallest element, and put it to the first position.
            //Find the next smallest element, and put it to the second position.
            //Repeat until all elements are sorted

            //32 7 45 23 41 19 28 50 1 37
            //1 7 45 23 41 19 28 50 32 37
            //1 7 45 23 41 19 28 50 32 37
            //1 7 19 23 41 45 28 50 32 37
            //1 7 19 23 41 45 28 50 32 37
            //1 7 19 23 28 45 41 50 32 37
            //1 7 19 23 28 32 41 50 45 37
            //1 7 19 23 28 32 37 50 45 41
            //1 7 19 23 28 32 37 41 45 50

            int[] selection = { 32, 7, 45, 23, 41, 19, 28, 50, 1, 37 };

            int tempo = Int32.MaxValue;
            int index = 0;

            for (int i = 0; i < selection.Length; i++)
            {
                for (int j = i; j < selection.Length; j++) 
                {
                    if (selection[j] < tempo)
                    {
                        tempo = selection[j];
                        index = j;
                    }
                }
                selection[index] = selection[i];
                selection[i] = tempo;
                tempo = 1000000;
            }

            // Or

            for (int i = 0; i < selection.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < selection.Length; j++)
                {
                    if (selection[j] < selection[min])
                    {
                        min = j;
                    }
                }
                int b = selection[i];
                selection[i] = selection[min];
                selection[min] = b;
            }

            /*Console.Write("Selection Sort: ");

            foreach (int i in selection)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); */
            
            // Insertion Sort

            //Take the first element as a sorted subarray
            //Insert the second element into the sorted subarray
            //(shift elements if needed)
            //Insert the third element into the sorted subarray
            //Repeat until all elements are inserted.

            //32 7 45 23 41 19 28 50 1 37

            //32 7 45 23 41 19 28 50 1 37
            //7 32 45 23 41 19 28 50 1 37
            //7 32 45 23 41 19 28 50 1 37
            //7 23 32 45 41 19 28 50 1 37
            //7 23 32 41 45 19 28 50 1 37
            //7 19 23 32 41 45 28 50 1 37
            //7 19 23 28 32 41 45 50 1 37
            //7 19 23 28 32 41 45 50 1 37
            //1 7 19 23 28 32 41 45 50 37

            int[] insertion = { 32, 7, 45, 23, 41, 19, 28, 50, 1, 37 };

            for (int i = 0; i < insertion.Length; i++)
            {
                int tmp = insertion[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (insertion[j - 1] < tmp) break;
                    insertion[j] = insertion[j - 1];
                }
                insertion[j] = tmp;

                //Console.WriteLine(string.Join(" ", insertion));
            }
        }
    }
}