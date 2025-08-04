using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{    
    public class Assignment
    {
        public List<string> Words { get; set; }

        public Assignment(string[] words)
        {
            Words = new List<string>(words);
        }

        public void BruteForce()
        {
            bool contains = false;
            List<string> list = new List<string>();

            for (int i = 0; i < Words.Count; i++)
            {
                if (Words.Count == 1)
                {
                    Console.WriteLine(Words[i]);
                }
                else
                {
                    list.Add(Words[i]);
                    //Console.WriteLine(string.Join(" ", list));
                    for (int j = i; j < Words.Count; j++)
                    {
                        string word = Words[j];
                        if (i != j)
                        {
                            for (int k = 0; k < word.Length; k++)
                            {
                                if (Words[i].Contains(word[k]))
                                {
                                    contains = true;
                                }
                                else
                                {
                                    contains = false;
                                    break;
                                }
                            }

                            if (contains)
                            {
                                list.Add(word);
                                Words.Remove(word);
                                contains = false;
                            }
                        }
                    }
                    Console.WriteLine(string.Join(" ", list));
                    list = new List<string>();
                }
            }   
        }

        public void Greedy()
        {
            List<string> anagrams = new List<string>();
            List<string> sorted = new List<string>();

            for (int i = 0; i < Words.Count; i++)
            {
                char[] word = Words[i].ToCharArray();
                Array.Sort(word);

                string temporary = "";
                foreach (char c in word)
                {
                    temporary += c;
                }
                sorted.Add(temporary);
            }

            for (int i = 0; i < sorted.Count; i++)
            {
                anagrams.Add(Words[i]);

                for (int j = 0; j < sorted.Count - 1; j++)
                {
                    if (sorted[j] == sorted[j + 1])
                    {
                        if (i != j)
                        {
                            anagrams.Add(Words[j]);
                            sorted.Remove(sorted[j]);
                        }
                        anagrams.Add(Words[j]);
                        sorted.Remove(sorted[j]);
                    }                    
                }
                sorted.Remove(sorted[i]);
                Console.WriteLine(string.Join(" ", anagrams));
                anagrams = new List<string>();
            }
        }
    }
}
