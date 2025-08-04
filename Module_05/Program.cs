using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] text = File.ReadAllLines("english.txt");

                Assignment assignment = new Assignment();
                string subwords = assignment.SubWords(input);
                List<string> exists = assignment.Exists(subwords, text);

                Console.WriteLine(string.Join(" ", exists));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (FileNotFoundException)
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