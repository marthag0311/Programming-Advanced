namespace _09_Connection
{
    internal class Program
    {
        /*
        Check if a weighted graph is connected or not. A graph is considered connected if there is a path between every pair of nodes.

        Input:
        5 --> nr of nodes
        3 --> nr of edges
        0,1,8 --> node 1, node 2, weight
        2,3,6
        3,4,9

        Output:
        not connected

        Explanation:
        There is no connection between 1 and 2

        Input
        3 --> nr of nodes
        2 --> nr of edges
        0,1,8
        1,2,9

        Output:
        connected

        Explanation;
        All nodes are connected, we can travel from node 0 to node 2
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
                    string[] array = Console.ReadLine().Split(",");
                    int[] integers = Array.ConvertAll(array, int.Parse);
                    assignment.AddEdge(integers[0], integers[1], integers[2]);
                    index++;
                }

                if (assignment.Connection()) Console.WriteLine("connected");
                else Console.WriteLine("not connected");
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