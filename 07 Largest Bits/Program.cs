using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Largest_Bits
{
    internal class Program
    {
        /*
        Read in a number and convert it to its 
        binary representation. Find all the 
        palindromic subsequences of that binary 
        number and print out the largest number!

        Eg: 10
        --> binary representation 1010
        --> subsequences: 101 10 1 010 01 0 10 1 0
        --> largest palindromic subsequence: 101 = 5

        input:
        10
        output:
        5

        input:
        102
        output:
        51
         */
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().Trim();

                if (Int32.TryParse(input, out int number) &&
                    number < 0)
                {
                    Assignment assignment = new Assignment();
                    //assignment.Largest(number);
                }
                else
                {
                    Console.WriteLine("Crazy input!");
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
        }
    }
}