using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    class Assignment
    {
        public string SubWords(string input)
        {
            string substrings = "";
            for (int i = 1; i <= input.Length; i++)
            {
                for (int j = 0; j <= input.Length - i; j++)
                {
                    if (input.Substring(j, i).Length >= 1)
                    {
                        substrings += (input.Substring(j, i)) + " ";
                    }
                }
            }
            return substrings;
        }

        public List<string> Exists(string substrings, string[] text)
        {
            string[] sub = substrings.Split(" ");

            List<string> result = new List<string>();

            for (int i = 0; i < sub.Length; i++)
            {
                if (text.Contains(sub[i].ToLower()))
                {
                    if (!result.Contains(sub[i].ToLower()))
                    {
                        result.Add(sub[i].ToLower());
                    }
                }
            }
            return result;
        }
    }
}
