namespace _08_Distance
{
    internal class Program
    {
        /*
        Implement a Breadth-First Search (BFS) algorithm to 
        determine the distance of each node from a given 
        start node in a graph.

        Input:
        4 --> nr of nodes
        3 --> nr of edges
        0 1
        1 2
        1 3
        0 --> start node
        output
        0 1 2 2
        explanation
        From the start node 0, the level of node 0 is 0, 
        node 1 is 1, and nodes 2 and 3 are 2.

 

        Input:
        4 --> nr of nodes
        2 --> nr of edges
        0 1
        2 3
        3 --> start node

        Output:
        -1 -1 1 0

        Explanation:
        From the start node 3, nodes 0 and 1 are not 
        reachable, hence their levels are -1. 
        The level of node 2 is 1 and node 3 is 0.
         */
        static void Main(string[] args)
        {
            try
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

                int start = Convert.ToInt32(Console.ReadLine());
                assignment.BFS(start);
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception)
            {
                Console.WriteLine("Crazy input!");
            }            
        }
    }
}