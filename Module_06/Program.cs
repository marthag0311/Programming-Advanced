using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string word = Console.ReadLine().ToLower().Trim();

                Assignment assignment = new Assignment();
                if (string.IsNullOrEmpty(word)) Console.WriteLine("Crazy input!");
                else
                {
                    List<string> subwords = assignment.Subwords(word);

                    string[] terms = File.ReadAllLines("english.txt");
                    List<string> words = new List<string>(terms);

                    List<string> sorted = assignment.Check(subwords, words);
                    Console.WriteLine(string.Join(" ", sorted));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input!");
            }
        }
    }
}