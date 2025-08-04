namespace _05_Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NQueens nqueens = new NQueens(8);
            nqueens.PlaceQueens(0);
            Console.WriteLine(nqueens);

            int[] array = new int[] { 4, 10, 2 };

            List<List<int>> result = new List<List<int>>();
            List<int> sublist = new List<int>();

            Subset subset = new Subset();

            subset.Solve(array, result, sublist);

            foreach (var item in result)
            {
                Console.Write(string.Join(" ", item));
            }
        }
    }
}