using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Longest_Path
{
    internal class Maze
    {
        int nodes;
        List<KeyValuePair<int, int>>[] graph;
        public Maze(int nodes)
        {
            this.nodes = nodes;
            graph = new List<KeyValuePair<int, int>>[nodes];

            for (int i = 0; i < nodes; i++)
            {
                graph[i] = new List<KeyValuePair<int, int>>();
            }
        }

        public void AddEdge(int node1, int node2, int weight)
        {
            graph[node1].Add(new KeyValuePair<int, int>(node2, weight));
        }

        public void LongestPath(int start)
        {
            int[] distances = new int[nodes];
            for (int i = 0; i < nodes; i++)
            {
                distances[i] = Int32.MinValue; // Initialize distances to negative infinity
            }

            int[] previous = new int[nodes];
            List<int> visited = new List<int>();

            distances[start] = 0;

            while (true)
            {
                int next = GetNextNode(distances, visited);

                if (next == -1) break;

                visited.Add(next);

                foreach (KeyValuePair<int, int> edge in graph[next])
                {
                    int neighbour = edge.Key;
                    int weight = edge.Value;

                    int cost = distances[next] + weight;
                    if (distances[neighbour] < cost)
                    {
                        distances[neighbour] = cost;
                        previous[neighbour] = next;
                    }
                }
            }
            int maxDistance = Int32.MinValue;
            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] > maxDistance)
                {
                    maxDistance = distances[i];
                }
            }
            Console.WriteLine(maxDistance);
        }

        private int GetNextNode(int[] distances, List<int> visited)
        {
            int next = -1;
            int max = Int32.MinValue;

            for (int i = 0; i < nodes; i++)
            {
                if (distances[i] > max && !visited.Contains(i))
                {
                    max = distances[i];
                    next = i;
                }
            }
            return next;
        }
    }
}
