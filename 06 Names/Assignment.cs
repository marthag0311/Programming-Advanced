using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Names
{
    class Assignment
    {
        public List<string> ListQuickSort(List<string> list)
        {
            if (list.Count <= 0) return list;

            string pivot = list[0];

            //"Martha","Geoffrey","Rozy","Alissa","Merina","Ananya"

            List<string> smaller = new List<string>();
            List<string> greater = new List<string>();

            foreach (var item in list)
            {
                if (String.Compare(item, pivot) < 0) smaller.Add(item.ToLower()); // item < pivot
                else if (String.Compare(item, pivot) > 0) greater.Add(item.ToLower()); // item > pivot
            }
            return ListQuickSort(smaller).Union(new List<string> { pivot }).Union(ListQuickSort(greater)).ToList<string>();
        }

        public int BinarySearch(List<string> list, string name)
        {
            int mid = 0;
            int start = 0;
            int end = list.Count - 1;

            while (start <= end)
            {
                mid = (start + end) / 2;
                
                if (name == list[mid])
                {
                    return mid;
                }
                else if (String.Compare(name, list[mid]) < 0)
                {
                    end = mid - 1;
                }
                else if (String.Compare(name, list[mid]) > 0)
                {
                    start = mid + 1;
                }
            }
            if (mid == 0) return 0;
            else return mid + 1;
        }
    }
}