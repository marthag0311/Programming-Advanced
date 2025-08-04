using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Unique
{
    internal class Program
    {
        /*
        Read in a string and remove all the same adjacent characters.

        Catch: you are not allowed to use loops or LINQ statements!

 

        Input/Output
        input:
        aabbccdde eff
        output:
        abcde ef

        input:
        abcdefg
        output:
        abcdefg
         */
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                List<char> letters = new List<char>();
                List<char> outcome = new List<char>();

                foreach (var item in input)
                {
                    letters.Add(item);
                }

                Assignment assignment = new Assignment();
                assignment.Print(assignment.Unique(letters, outcome));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}