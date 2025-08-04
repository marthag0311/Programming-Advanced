using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Nth_Character
{
    internal class Program
    {
        /*
         Combine all words from the given file Download 
        from the given file(already in CodeGrade) into 
        one big string and find the nth character. Try 
        to solve each exercise in different ways, always 
        start from the naive approach first (brute force), 
        and then try to work more efficiently based on 
        what we saw in the lesson! Think what Big(O) could be!

        CodeGrade Setup = .Net framework 6.0

        input:
        4728391
        output:
        h

        input:
        9256087
        output:
        k

        Code instructions

        To solve this assignment you need to create a 
        Module_01 namespace with an Assignment class 
        and a method NthCharacter
        
         */
        static void Main(string[] args)
        {
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Assignment assignment = new Assignment();
                //Console.WriteLine(assignment.NthCharacter(number, "words.txt"));
                //Console.WriteLine(assignment.BruteForce(number, "words.txt"));
                //Console.WriteLine(assignment.LinearSearch(number, "words.txt"));
                //Console.WriteLine(assignment.BinarySearch(number, "words.txt"));
                Console.WriteLine(assignment.StupidSearch(number, "words.txt"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (FileNotFoundException)
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