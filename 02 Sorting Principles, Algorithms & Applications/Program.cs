namespace _02_Sorting_Principles__Algorithms___Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bubble Sort
            int[] array = { 32, 7, 45, 23, 41, 19, 28, 50, 1, 37 };

            Sorting sort = new Sorting();
            sort.Bubble(array);

        }
    }
}