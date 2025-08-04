using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Minimum
{
    internal class Assignment
    {
        public int Minimum(List<int> list, int smallest)
        {
            if (list.Count == 0)
            {
                return smallest;
            }
            else
            {
                if (list[0] < smallest)
                {
                    smallest = list[0];
                }
                list.RemoveAt(0);
                return Minimum(list, smallest);
            }
        }
    }
}
