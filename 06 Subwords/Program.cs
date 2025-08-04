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
        /*
        Find all subwords (more than 1 character) of a given 
        string, and use the file english.txt Download 
        english.txt(already in CodeGrade) to check. Output 
        all subwords in sorted order.

        input:
        Hello
        output:
        el ell he hel hell lo

        Explanation:
        all subwords (more than 1 char): he hel hell el ell ello ll llo lo 
        all subwords that are actually words (test with english.txt): el ell he hel hell lo

        input:
        Worcestershire
        output:
        ce er ers es est ester esters hi hire ire or orc re sh shire st te wo worcester
         */
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