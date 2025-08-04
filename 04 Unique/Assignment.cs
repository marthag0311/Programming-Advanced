using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unique
{
    internal class Assignment
    {
        public List<char> Unique(List<char> input, List<char> outcome, string temp = "")
        {
            if (input.Count == 0)
            {
                outcome.AddRange(temp);
                return outcome;
            }
            else
            {
                if (input[0] == ' ')
                {
                    outcome.AddRange(temp);
                    temp = "";
                }

                if (!temp.Contains(input[0]))
                {
                    temp += input[0];
                }

                input.RemoveAt(0);
                return Unique(input, outcome, temp);
            }
        }

        public void Print(List<char> unique)
        {
            foreach (var item in unique)
            {
                Console.Write(item);
            }
        }
    }
}
