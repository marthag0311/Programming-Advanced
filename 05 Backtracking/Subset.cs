using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Backtracking
{
    class Subset
    {
        public void Solve(int[] array, List<List<int>> result, List<int> sublist, int index = 0)
        {
            result.Add(new List<int>(sublist)); //otherwise adding reference

            for (int i = 0; i < array.Length; i++)
            {
                sublist.Add(array[i]);
                Solve(array, result, sublist, index + 1);
                sublist.RemoveAt(sublist.Count - 1);
            }
        }
    }
}
