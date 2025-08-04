using System.Linq.Expressions;

namespace _00_Trial_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Trim().Split();
            int[] integers = Array.ConvertAll(array, int.Parse);
                        
            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.BruteForce(integers));
            Console.WriteLine(assignment.Greedy(integers));
            //assignment.TraversePostOrder();

            foreach (int value in integers)
            {
                assignment.Add(value);
            }
            Console.WriteLine(assignment.FindMax());
        }
    }
}