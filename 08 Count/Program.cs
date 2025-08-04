using System.Linq.Expressions;

namespace _08_Count
{
    internal class Program
    {
        /*
        Implement a Depth-First Search (DFS) algorithm to 
        determine the number of connected components in a graph.

        Input:
        5 --> nr of nodes
        3 --> nr of edges
        0 1
        2 3
        3 4
        Output:
        2
        Explanation:
        There are two connected components in this graph: one 
        containing nodes 0 and 1, and the other containing nodes 
        2, 3, and 4.

 

        Input:
        4 --> nr of nodes
        1 --> nr of edges
        0 2
        Output:
        3
        Explanation:
        There are three connected components in this graph: one 
        containing nodes 0 and 2, and two single-node components 
        containing nodes 1 and 3.
         */
        static void Main(string[] args)
        {
            int nodes = Convert.ToInt32(Console.ReadLine());
            int edges = Convert.ToInt32(Console.ReadLine());

            Assignment assignment = new Assignment(nodes);

            int index = 0;

            while (index < edges)
            {
                string[] all = Console.ReadLine().Split(' ');
                int[] integers = Array.ConvertAll(all, int.Parse);
                assignment.AddEdge(integers[0], integers[1]);
                index++;
            }
            Console.WriteLine(assignment.Count());
        }
    }
}