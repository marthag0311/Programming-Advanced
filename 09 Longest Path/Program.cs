namespace _09_Longest_Path
{
    internal class Program
    {
        /*
        Find the longest path in the given Directed 
        Acyclic Graph. Always start your search from 
        the first node!

        Input
        4 --> nr of nodes
        4 --> nr of edges
        0,1,2 --> node 1, node 2, weight
        1,2,3
        2,3,4
        0,2,1
        output
        9

        Input
        5 --> nr of nodes
        6 --> nr of edges
        0,1,3
        1,2,4
        0,2,2
        2,3,6
        1,3,5
        3,4,2
        output
        15
         */
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());

                Maze maze = new Maze(nodes);
                int index = 0;
                while (index < edges)
                {
                    string[] array = Console.ReadLine().Split(",");
                    int[] ints = Array.ConvertAll(array, int.Parse);
                    maze.AddEdge(ints[0], ints[1], ints[2]);
                    index++;
                }
                maze.LongestPath(0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy Input!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Crazy Input!");
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy Input!");
            }            
        }
    }
}