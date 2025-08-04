using System;
using System.IO;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine().ToLower().Trim().Split(" ");
            Assignment assignment = new Assignment(words);
            assignment.BruteForce();
            assignment.Greedy();
             
        }
    }
}