using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sum
{
    internal class Program
    {
        /*
        Read in a word and add up all the digits

        Catch: you are not allowed to use loops or LINQ statements!

 

        Input/Output
        input:
        123456789 are all digits
        output:
        45

        input:
        There are no digits
        output:
        0
         */
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                List<char> chars = new List<char>();

                foreach (var item in input)
                {
                    chars.Add(item);
                }

                Assignment assignment = new Assignment();
                Console.Write(assignment.Sum(chars));
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