using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum
{
    internal class Assignment
    {
        public int Sum(List<char> chars, int sum = 0)
        {
            if (chars.Count == 0)
            {
                return sum;
            }
            else
            {
                if (chars[0] == '1' || chars[0] == '2' || chars[0] == '3' || chars[0] == '4'
                    || chars[0] == '5' || chars[0] == '6' || chars[0] == '7' || chars[0] == '8' || chars[0] == '9')
                {
                    sum += Convert.ToInt32(chars[0] - '0');
                }
                chars.RemoveAt(0);
                return Sum(chars, sum);
            }

        }
    }
}
