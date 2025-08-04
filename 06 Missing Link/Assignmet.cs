using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    internal class Assignment
    {
        public List<int> ListQuickSort(List<int> list)
        {
            if (list.Count <= 0) return list;

            int pivot = list[0];

            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();

            foreach (var item in list)
            {
                if (item < pivot) smaller.Add(item);
                else if (item > pivot) greater.Add(item);
            }
            return ListQuickSort(smaller).Union(new List<int> { pivot }).Union(ListQuickSort(greater)).ToList<int>();
        }

        public string MissingLink(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] + 1 != list[i + 1] && list[i] > 0)
                {
                    return (list[i] + 1).ToString();
                }
            }
            return "No missing link";
        }
    }
}

