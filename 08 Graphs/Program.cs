namespace _08_Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Maze maze = new Maze(25);

            maze.AddEdge(0, 1);
            maze.AddEdge(1, 2);
            maze.AddEdge(2, 3);
            maze.AddEdge(3, 4);
            maze.AddEdge(4, 9);
            maze.AddEdge(9, 14);
            maze.AddEdge(18, 17);
            maze.AddEdge(18, 19);
            maze.AddEdge(19, 14);
            maze.AddEdge(19, 24);
            maze.AddEdge(24, 23);
            maze.AddEdge(18, 23);
            maze.AddEdge(22, 23);
            maze.AddEdge(17, 12);
            maze.AddEdge(21, 22);
            maze.AddEdge(21, 20);
            maze.AddEdge(20, 15);
            maze.AddEdge(15, 10);
            maze.AddEdge(10, 5);
            maze.AddEdge(5, 0);

            Console.WriteLine(maze.ToString());

            List<int> visited = maze.DFS(12, null);
            Console.WriteLine("DFS RECURSION: " + String.Join(" -> ", visited));

            List<int> nodes = maze.DFS(12, null, 0);
            Console.WriteLine("DFS RECUSION:" + String.Join(" -> ", nodes));

            Console.WriteLine("DFS STACK: " + maze.DFS(12));

            Console.WriteLine("BFS:" + maze.BFS(12, 0));*/

            Practice practice = new Practice(25);

            practice.AddEdge(0, 1);
            practice.AddEdge(1, 2);
            practice.AddEdge(2, 3);
            practice.AddEdge(3, 4);
            practice.AddEdge(4, 9);
            practice.AddEdge(9, 14);
            practice.AddEdge(18, 17);
            practice.AddEdge(18, 19);
            practice.AddEdge(19, 14);
            practice.AddEdge(19, 24);
            practice.AddEdge(24, 23);
            practice.AddEdge(18, 23);
            practice.AddEdge(22, 23);
            practice.AddEdge(17, 12);
            practice.AddEdge(21, 22);
            practice.AddEdge(21, 20);
            practice.AddEdge(20, 15);
            practice.AddEdge(15, 10);
            practice.AddEdge(10, 5);
            practice.AddEdge(5, 0);

            //List<int> visited = practice.DFS(12, null);
            //Console.WriteLine(string.Join(" --> ", visited));

            List<int> nodes = practice.DFS(12, null, 0);
            Console.WriteLine(string.Join(" --> ", nodes));

            //Console.WriteLine(practice.BFS(12, 0));
        }
    }
}