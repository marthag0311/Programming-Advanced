using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Count
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

        public int Count()
        {
            bool[] visited = new bool[nodes];
            int connected = 0;

            for (int i = 0; i < nodes; i++)
            {
                if (!visited[i])
                {
                    DFS(i, visited);
                    connected++;
                }
            }
            return connected;
        }

        private void DFS(int start, bool[] visited)
        {
            visited[start] = true;

            foreach (int neighbor in graph[start])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, visited);
                }
            }
        }
    }
}
