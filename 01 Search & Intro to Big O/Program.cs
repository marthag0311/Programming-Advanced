namespace _01_Search___Intro_to_Big_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Array.ConvertAll(File.ReadAllLines("sorted_numbers.txt"), Int32.Parse);

            int[] array = new int[] { 3, 5, 6, 7, 8 };

            Searching searching = new Searching();

            int number = 5;
            Console.WriteLine($"STUPID: {number} {searching.Stupid(array, number)} - count: {searching.count}");
            Console.WriteLine("aaaaaaa");

            /*
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
        }

        public static void Example(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 1; i < n; i *= 2)
            {
                matrix[i, i] = 1;
            }
        }
    }
}