using System;
using System.Xml.Linq;

namespace _02_Where_is_Wally___Reseach_Assignment
{
    internal class Program
    {
        /*
        You have a big file full of names names.txt 
        Download names.txtin random order. Your job 
        is to find the name "Wally" in this list. 
        You learned about a fast way to find things 
        called Binary Search in a previous lesson. 
        But for it to work, the names need to be sorted. 
        So, you'll need to sort the names first before 
        looking for "Wally".

        Before using a simple fix like Array.Sort(), 
        go to the lesson, and take a look at the three 
        sorting methods in the slides. First, use these 
        three methods to sort the names and find "Wally". 
        Then, choose any two other sorting methods from 
        the list below and try them out too.

        Counting Sort
        Radix Sort
        Bucket Sort
        Shell Sort
        Cocktail Shaker Sort (or Shaker Sort)
        Comb Sort
        Gnome Sort
        Odd-even Sort
        Cycle Sort
        Pancake Sorting
        Pigeonhole Sort
        Flashsort
        American Flag Sort
        Block Sort
        Brick Sort
        Now, create a document (pdf, write in English). 
        Write down all your code for finding Wally and 
        the two sorting methods you picked, explain how 
        they work, and compare them. Look at how fast 
        they run and how much computer memory they use.
        Make sure to show that you really understand 
        what you're doing and put in a good effort.
         */

        private static void Swap(string[] array, int pos1, int pos2)
        {
            string temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        private static string[] Bubble(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (String.Compare(array[j + 1], array[j]) < 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
            return array;
        }       

        private static string[] Selection(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (String.Compare(array[j], array[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(array, i, min);
            }

            return array;
        }

        private static string[] Insertion(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string tmp = array[i];
                int j;

                for (j = i; j > 0; j--)
                {
                    if (String.Compare(array[j - 1], tmp) < 0)
                    {
                        break;
                    }
                    array[j] = array[j - 1];
                }
                array[j] = tmp;
            }
            return array;
        }

        private static string[] Bucket(string[] array)
        {
            List<string>[] buckets = new List<string>[26];

            foreach (string element in array)
            {
                int number = char.ToUpper(element[0]) - 'A';
                
                if (buckets[number] == null)
                {
                    buckets[number] = new List<string>();
                }
                buckets[number].Add(element);
            }

            int index = 0;
            foreach (List<string> bucket in buckets)
            {
                if (bucket != null)
                {
                    string[] insertion = Insertion(bucket.ToArray());

                    foreach (string element in insertion)
                    {
                        array[index] = element;
                        index++;
                    }
                }
            }
            return array;
        }

        private static string[] Shell(string[] array)
        {
            int gap = 1;

            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap > 0)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    string temporary = array[i];
                    int index = i;

                    while (index >= gap && string.Compare(array[index - gap], temporary) > 0)
                    {
                        array[index] = array[index - gap];
                        index -= gap;
                    }

                    array[index] = temporary;
                }

                gap /= 3;
            }

                return array;
        }

        private static int Binary(string[] array, string name)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (array[mid] == name)
                {
                    return mid;
                }
                else if (String.Compare(name, array[mid]) < 0)
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
        
        static void Main(string[] args)
        {
            string[] array = File.ReadAllLines("names.txt");

            string[] bubble = Bubble(array);
            Console.WriteLine(Binary(bubble, "Wally"));

            string[] selection = Selection(array);
            Console.WriteLine(Binary(selection, "Wally"));

            string[] insertion = Insertion(array);
            Console.WriteLine(Binary(insertion, "Wally"));

            string[] bucket = Bucket(array);
            Console.WriteLine(Binary(bucket, "Wally"));

            string[] shell = Shell(array);
            Console.WriteLine(Binary(shell, "Wally"));

        }
    }
}