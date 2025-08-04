using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _01_Duplicates
{
    internal class Assignment
    {
        public string Duplicates(string start, string filename)
        {
            string[] words = File.ReadAllLines(filename);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string line in words)
            {
                if (line.StartsWith(start))
                {
                    if (dict.ContainsKey(line))
                    {
                        dict[line]++;
                    }
                    else
                    {
                        dict[line] = 1;
                    }
                }
            }

            string unique = "";

            foreach (var pair in dict)
            {
                unique += pair.Key + " ";
            }

            return unique.TrimEnd(); 
        }
        public string BruteForce(string start, string filename)
        {
            //Overall space complexity is O(n + k) = O(n)
            //Overall time complexity is O(n + k) = O(n)
            string[] words = File.ReadAllLines(filename); //time & space complexity = o(n)

            Dictionary<string, int> dict = new Dictionary<string, int>(); //space complexity = O(k)

            for (int i = 0; i < words.Length; i++) //time complexity = O(n)
            {
                if (words[i].StartsWith(start))
                {
                    if (!dict.ContainsKey(words[i])) dict[words[i]] = 1; //space complexity = O(1)
                    else dict[words[i]]++; //space complexity = O(1)
                }
            }

            List<string> unique = new List<string>(); //space complexity = O(k)

            foreach (var pair in dict) //time complexity = O(k)
            {
                if (pair.Value > 1)
                {
                    unique.Add(pair.Key);
                }
            }

            string output = "";

            foreach (string item in unique) //time complexity = O(k)
            {
                output += item + " ";
            }           
            
            return output;
        }        
    }
}
