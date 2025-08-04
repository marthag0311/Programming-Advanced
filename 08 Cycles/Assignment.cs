using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cycles
{
    internal class Assignment
    {
        int nodes;
        List<int>[] graph;

        public Assignment(int nodes)
        {
            this.nodes = nodes;
            graph = new List<int>[nodes]; //create graph with nr of nodes

            for (int i = 0; i < nodes; i++) //initialize all lists
            {
                graph[i] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            //to make it better, check if a node already is in the list, not going out of bounds
            graph[node1].Add(node2);
            //graph[node2].Add(node1);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < nodes; i++)
            {
                s += i + " --> " + String.Join(" ", graph[i]) + "\n";
            }
            return s;
        }

        public bool IsCyclic()
        {
            List<int> visited = new List<int>();

            for (int i = 0; i < nodes; i++)
            {
                if (!visited.Contains(i) && DFS(i, visited))
                {
                    return true;
                }
            }
            return false;
        }

        private bool DFS(int start, List<int> visited)
        {
            //If the node is already visited and is present
            //in the recursion stack, then there is a cycle
            if (visited.Contains(start)) return true;
           
            visited.Add(start);

            foreach (int neighbor in graph[start])
            {
                if (DFS(neighbor, visited))
                {
                    return true;
                }
            }
            visited.Remove(start); // Backtrack

            return false;
        }
    }
}
