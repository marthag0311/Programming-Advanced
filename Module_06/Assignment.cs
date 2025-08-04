using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    internal class Assignment
    {
        public List<string> Subwords(string word)
        {
            string temp = "";
            List<string> list = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i; j < word.Length; j++)
                {
                    temp += word[j];

                    if (temp.Length > 1 && temp != word)
                    {
                        list.Add(temp);
                    }
                }
                temp = "";
            }
            return list;
        }

        public List<string> Check(List<string> subwords, List<string> words)
        {
            List<string> contains = new List<string>();

            foreach (var item in subwords)
            {
                if (words.Contains(item))
                {
                    contains.Add(item);
                }
            }
            return ListQuickSort(contains);
        }

        public List<string> ListQuickSort(List<string> list)
        {
            if (list.Count <= 0) return list;

            string pivot = list.First();

            List<string> smaller = new List<string>();
            List<string> greater = new List<string>();

            foreach (var item in list)
            {
                if (String.Compare(item, pivot) < 0) smaller.Add(item);
                else if (String.Compare(item, pivot) > 0) greater.Add(item);
            }
            return ListQuickSort(smaller).Union(new List<string> { pivot }).Union(ListQuickSort(greater)).ToList<string>();
        }
    }
}
