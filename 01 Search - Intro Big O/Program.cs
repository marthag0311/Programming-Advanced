namespace _01_Search___Intro_Big_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), Int32.Parse);

            /*int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Searching searching = new Searching();

            
            int number = 45;
            Console.WriteLine($"LINEAR: {number} {searching.Linear(array, number)} - count: {searching.count}");
            Console.WriteLine($"STUPID: {number} {searching.Stupid(array, number)} - count: {searching.count}");
            Console.WriteLine($"BINARY: {number} {searching.Binary(array, number)} - count: {searching.count}");
            Console.WriteLine();

            number = 46;
            Console.WriteLine($"LINEAR: {number} {searching.Linear(array, number)} - count: {searching.count}");
            Console.WriteLine($"STUPID: {number} {searching.Stupid(array, number)} - count: {searching.count}");
            Console.WriteLine($"BINARY: {number} {searching.Binary(array, number)} - count: {searching.count}");
            Console.WriteLine();

            number = 998;
            Console.WriteLine($"LINEAR: {number} {searching.Linear(array, number)} - count: {searching.count}");
            Console.WriteLine($"STUPID: {number} {searching.Stupid(array, number)} - count: {searching.count}");
            Console.WriteLine($"BINARY: {number} {searching.Binary(array, number)} - count: {searching.count}");
            Console.WriteLine();*/

            int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), int.Parse);

            Practice practice = new Practice(50, array);
            Console.WriteLine(practice.Linear() + " => number of attempts = " + practice.attempts);
            Console.WriteLine(practice.Binary() + " => number of attempts = " + practice.attempts);
            Console.WriteLine(practice.Stupid() + " => number of attempts = " + practice.attempts);
        }
    }
}