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
                string[] numbers = Console.ReadLine().Split(" ");
                int[] array = Array.ConvertAll(numbers, int.Parse);

                List<int> list = new List<int>(array);

                Assignment assignment = new Assignment();
                List<int> sorted = assignment.ListQuickSort(list);
                string number = assignment.MissingLink(sorted);
                Console.WriteLine(number);
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