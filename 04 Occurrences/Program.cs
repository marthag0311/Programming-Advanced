using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Occurrences
{
    internal class Program
    {
        /*
        Find the occurrence of a number (first line of input) in a sequence of numbers (second line of input)

        Catch: you are not allowed to use loops or LINQ statements!


        Input/Output
        input:
        8
        7 8 5 4 1 2 8 8 9 6 5 4 8
        output:
        4

        input:
        0
        0 0 0 0 4 5 8 7 4 0 0
        output:
        6
         */
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                string[] input = Console.ReadLine().Split(" ");

                List<int> numbers = new List<int>();
                foreach (var item in input)
                {
                    numbers.Add(Convert.ToInt32(item));
                }

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Occurences(numbers, number, 0));
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