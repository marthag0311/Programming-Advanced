using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Minimum
{
    internal class Program
    {
        /*
        Find the minimum element in a given array.

        Catch: you are not allowed to use loops or LINQ statements!

        CodeGrade Setup = .Net framework 6.0


        Input/Output
        input:
        1 2 5 4 7 8 1
        output:
        1

        input:
        5 6 9 8 7 4 10 0 2 -4 5 7
        output:
        -4
         */
        static void Main(string[] args)
        {
            try
            {
                string[] array = Console.ReadLine().Split();

                List<int> input = new List<int>();

                foreach (var item in array)
                {
                    input.Add(Convert.ToInt32(item));
                }

                Assignment assignment = new Assignment();

                Console.WriteLine(assignment.Minimum(input, input[0]));
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