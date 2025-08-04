namespace _06_Divide___Conquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum();
            Console.WriteLine(sum.Iterative(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(sum.DCList(new List<int>(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(sum.DCArray(new int[] { 1, 2, 3, 4, 5 }));

            List<int> list = new List<int>(new int[] { 2, 7, 9, 1, 10, 8, 14, 21, 4, 5, 18, 19 });
            Quicksort quicksort = new Quicksort();
            list = quicksort.Sort(list);
            Console.WriteLine(string.Join(" ", list));

            Hanoi hanoi = new Hanoi();
            Console.WriteLine("1 DISK");
            hanoi.Solve(3, 'A', 'C', 'B');

        }
    }
}