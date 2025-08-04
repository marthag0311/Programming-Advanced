using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Module_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cipher = Console.ReadLine().Trim();

                Assignment assignment = new Assignment("english.txt");
                var decrypted = assignment.DecryptCipher(cipher);

                if (decrypted != null)
                {
                    Console.WriteLine($"Shift {decrypted.Item2} - {decrypted.Item1}");
                }
                else Console.WriteLine("Crazy input!");
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