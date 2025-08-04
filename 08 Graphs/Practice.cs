using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Graphs
{
    internal class Practice
    {
        int nodes;
        List<int>[] graph;

        public Practice(int nodes)
        {
            this.nodes = nodes;

            graph = new List<int>[nodes];

            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }
        
        public List<int> DFS(int start, List<int> visited)
        {
            if (visited == null) visited = new List<int>();

            visited.Add(start);

            foreach (int node in graph[start])
            {
                if(!visited.Contains(node))
                {
                    DFS(node, visited);
                }
            }
            return visited;
        }

        public List<int> DFS(int start, List<int> visited, int stop)
        {
            if (visited == null) visited = new List<int>();

            visited.Add(start);
            if (start == stop) return visited;

            foreach(int node in graph[start])
            {
                if (!visited.Contains(node))
                {
                    List<int> nodes = DFS(node, visited, stop);
                    Console.WriteLine("Nodes: " + string.Join(" ", nodes));
                    if (nodes.Contains(stop)) return nodes;
                }
            }
            return visited;
        }

        public string BFS(int start, int stop)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            List<int> visited = new List<int>();
            visited.Add(start);

            while(queue.Count != 0)
            {
                int node = queue.Dequeue();

                foreach (int neighbor in graph[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                        if (node == stop) return string.Join(" -> ", visited);
                    }
                }
            }
            return string.Join(" ", visited);
        }
    }
}