using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Distance
{
    internal class Assignment
    {
        int nodes;
        List<int>[] graph;

        public Assignment(int nodes)
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

        public void BFS(int start)
        {
            bool[] visited = new bool[nodes];
            int[] distances = new int[nodes];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < nodes; i++)
            {
                distances[i] = -1;
            }

            visited[start] = true;
            distances[start] = 0;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                int current = queue.Dequeue();

                foreach (int neighbor in graph[current])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        distances[neighbor] = distances[current] + 1;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.Write(string.Join(" ", distances));
        }
    }
}
