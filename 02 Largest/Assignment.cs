using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Largest
{
    internal class Assignment
    {
        public string Read(string input)
        {
            string[] sarray = input.Split(" ");

            int[] array = Array.ConvertAll(sarray, int.Parse);

            List<int> list = array.ToList();

            Largest(list);

            string largest = string.Join("", list);
            return largest;

            /*int max = array.Max();
            int bucketsN = max + 1;

            List<List<int>> buckets = new List<List<int>>(bucketsN);

            for (int i = 0; i < bucketsN; i++)
            {
                buckets.Add(new List<int>());
            }

            foreach (int element in array)
            {
                int digit = element / 10; 
                buckets[digit].Add(element);
            }

            int index = 0;
            List<int> list = new List<int>();
            foreach (List<int> bucket in buckets)
            {
                if (bucket != null)
                {
                    int[] insertion = Insertion(bucket.ToArray());

                    foreach (int element in insertion)
                    {
                        array[index] = element;
                        index++;
                    }
                }
            }*/
        }

        static void Largest(List<int> list)
        {
            list.Sort((a, b) =>
            {
                string letterA = a.ToString();
                string letterB = b.ToString();

                string seqAB = letterA + letterB;
                string seqBA = letterB + letterA;

                return seqBA.CompareTo(seqAB); 
            });
        }
    }
}
