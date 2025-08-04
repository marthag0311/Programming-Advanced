using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Missing
{
    internal class Assignment
    {
        public string Missing(int[] array)
        {
            int[] unique = array.Distinct().ToArray();

            int count = unique[0];

            if (unique[0] < unique[1])
            {
                foreach (int i in array)
                {
                    if (count == i)
                    {
                        count++;
                    }
                    else
                    {
                        return count.ToString();
                    }
                }
            }
            else
            {
                foreach (int i in array)
                {
                    if (count == i)
                    {
                        count--;
                    }
                    else
                    {
                        return count.ToString();
                    }
                }
            } 
            return "No missing number.";
        }
    }
}
