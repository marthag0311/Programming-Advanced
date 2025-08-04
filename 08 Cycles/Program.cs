 namespace _08_Cycles
{
    internal class Program
    {
        /*
        Implement a Depth-First Search (DFS) algorithm to check if there's a cycle in a given directed graph. Read in the number of nodes, the number of edges, and a list of all edges. Output "cyclic" if there is a cycle in the graph, or "acyclic" if there isn't.

        image.png
        cyclic graph:
        A <- B
        |   >
        >  /
          C

        acyclic graph:
        A -> B
        |    >
        >   /
          C

        Input
        3 --> nr of nodes
        2 --> nr of edges
        1 1
        1 2
        output
        cyclic

        Input
        3 --> nr of nodes
        3 --> nr of edges
        0 1
        1 2
        0 2
        output
        acyclic
         */
        static void Main(string[] args)
        {
            int nodes = Convert.ToInt32(Console.ReadLine());
            int edges = Convert.ToInt32(Console.ReadLine());

            Assignment assignment = new Assignment(nodes);

            int index = 0;

            while (index < edges)
            {
                string all = Console.ReadLine();

                //if (string.IsNullOrWhiteSpace(all)) break;

                string[] strings = all.Split(' ');
                int[] integers = Array.ConvertAll(strings, int.Parse);

                assignment.AddEdge(integers[0], integers[1]);              
            }

            if (assignment.IsCyclic()) Console.WriteLine("cyclic");
            else Console.WriteLine("acyclic");
        }
    }
}