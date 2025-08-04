using System;
using TM.ProgrammingAdvanced;
namespace _04_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = Data.Folders(@"C:\shrhydmsm4t"); //string folder = @"C:\shrhydmsm4t";
            Console.WriteLine("Base folder: " + folder);

            FindKey find = new FindKey(folder);
            find.Count = 0;
            Console.WriteLine($"File found: {find.Algorithm1()}: count {find.Count}");
            Console.WriteLine($"File found: {find.Algorithm2(folder)}: count {find.Count}");

            Factorial factorial = new Factorial();
            Console.WriteLine($"10!: {factorial.Iterative()}");
            Console.WriteLine($"10!: {factorial.Recursion()}");

            Exercises ex = new Exercises();
            Console.WriteLine(ex.Sum(9));
            Console.WriteLine(ex.Digits(10000));
            Console.WriteLine(ex.Reverse("programming"));
        }
    }
}