using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Names
{
    internal class Program
    {
        /*
        Given an (unsorted) file of names 
        (names.txt already in CodeGrade). 
        Read a name and find its (new) place (index) in the 
        sorted name list.

        input:
        Elke
        output:
        5158

        input:
        Collin
        output:
        3353
         */
        static void Main(string[] args)
        {
            //string name = Console.ReadLine().ToLower().Trim();
            //string[] array = File.ReadAllLines("names.txt");
            //List<string> list = new List<string>(array);

            List<string> list = new List<string>(new int[] {"Martha","Geoffrey","Rozy","Alissa","Merina","Ananya" });

            Assignment assignment = new Assignment();
            List<string> sorted = assignment.ListQuickSort(list);
            Console.WriteLine(string.Join(" ", sorted));
            //int index = assignment.BinarySearch(sorted, name);
            //Console.WriteLine(index);
        }
    }
}