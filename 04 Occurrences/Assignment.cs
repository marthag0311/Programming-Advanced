using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Occurrences
{
    internal class Assignment
    {
        public int Occurences(List<int> numbers, int number, int count)
        {
            if (numbers.Count == 0)
            {
                return count;
            }
            else
            {

                if (numbers[0] == number)
                {
                    count++;
                }
                numbers.RemoveAt(0);

                return Occurences(numbers, number, count);
            }
        }
    }
}
