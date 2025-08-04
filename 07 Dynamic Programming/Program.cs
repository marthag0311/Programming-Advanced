namespace _07_Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            int n = 5;

            //Console.WriteLine("*** RECURSION ***");
            //Console.WriteLine("Recursion: " + fibonacci.Recursion(n));
            //Console.WriteLine();
            //Console.WriteLine("*** MEMOIZATION ***");
            //Console.WriteLine("Memoization: " + fibonacci.Memoization(n, new int[n+1]));
            //Console.WriteLine();
            //Console.WriteLine("*** TABULATION ***");
            //Console.WriteLine("Tabulation: " + fibonacci.Tabulation(n));
            //Console.WriteLine();
            //Console.WriteLine("*** INTERATIVE ***");
            //Console.WriteLine("Interative: " + fibonacci.Iterative(n));

            int[] array = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
            RodCutting rodCutting = new RodCutting(array);

            //Console.WriteLine(rodCutting.Recursion(4));
            //Console.WriteLine(rodCutting.Memoization(4, new int[5]));
            //Console.WriteLine(rodCutting.Tabulation(4));

            Draft draft = new Draft(array);

            Console.WriteLine(draft.Recursion(4));
            //Console.WriteLine(rodCutting.Memoization(4, new int[5]));
            //Console.WriteLine(rodCutting.Tabulation(4));

        }
    }
}