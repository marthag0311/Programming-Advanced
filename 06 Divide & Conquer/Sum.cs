using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Divide___Conquer
{
    internal class Sum
    {
        public int Iterative(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int DCList(List<int> list)
        {
            if (list.Count == 0) return 0;
            //if (list.Count == 1) return list[0];

            int first = list[0];
            list.Remove(list[0]);
            return first + DCList(list);
        }

        public int DCArray(int[] array, int index = 0)
        {
            if (index == array.Length) return 0;

            return array[index] + DCArray(array, ++index);

            //return array[index] + DCArray(array, index + 1); OK!
            //return array[index] + DCArray(array, index++); PROBLEM!! POST INCREMENTATION
        }
    }
}
