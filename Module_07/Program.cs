using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module_07
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                Assignment assignment = new Assignment();

                if (input <= 0) Console.WriteLine("Crazy input!");
                else
                {
                    string descend = assignment.Sequence(input);
                    Console.WriteLine(assignment.Sum(input, descend));
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