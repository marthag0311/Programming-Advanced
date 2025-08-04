using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split(" ");

                if (!(input.Length > 2 || input.Length < 2))
                {
                    int[] array = Array.ConvertAll(input, Int32.Parse);

                    int first = array[0];
                    int second = array[1];

                    Assignment assignment = new Assignment();
                    Console.WriteLine(assignment.Multiplication(first, second));
                }
                else Console.WriteLine("Crazy input!");
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