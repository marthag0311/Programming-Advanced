using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_07
{
    class Assignment
    {
        public string Sequence(int number)
        {
            if (number == 1) return "";

            string seq = "";

            if (number % 2 == 0)
            {
                number = number / 2;
                seq = Sequence(number) + number + " ";
            }
            else
            {
                number = (3 * number) + 1;
                seq = Sequence(number) + number + " ";
            }
            return seq;
        }

        public int Sum(int number, string seq)
        {
            string[] array = seq.Split(" ");

            List<string> list = new List<string>();

            int sum = number;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (Int32.TryParse(array[i], out int n))
                {
                    sum += n;
                }
                list.Add(array[i]);
            }
            Console.Write(number + string.Join(" ", list) + "\n");
            return sum;
        }                
    }
}
