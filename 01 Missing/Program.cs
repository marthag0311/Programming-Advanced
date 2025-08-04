using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _01_Missing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                string[] array = Console.ReadLine().Split(' ');

                int[] integers = Array.ConvertAll(array, Convert.ToInt32);

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Missing(integers));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            
            try
            {
                int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                Practice practice = new Practice(array);
                Console.WriteLine(practice.BruteForce());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}