using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Module_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());

                Assignment assignment = new Assignment(nodes);

                int index = 0;

                while (index < edges)
                {
                    string[] all = Console.ReadLine().Split(' ');
                    int[] integers = Array.ConvertAll(all, int.Parse);
                    assignment.AddEdge(integers[0], integers[1]);
                    index++;
                }
                Console.WriteLine(assignment.Count());
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