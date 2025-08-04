namespace _09_Connection
{
    internal class Assignment
    {
        int nodes;
        List<KeyValuePair<int, int>>[] graph;

        public Assignment(int nodes)
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
            graph[node2].Add(new KeyValuePair<int, int>(node1, weight));
        }

        public bool Connection()
        {
            bool[] visited = new bool[nodes];
            DFS(0, visited);

            for (int i = 0; i < nodes; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void DFS(int node, bool[] visited)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var neighbor in graph[node])
            {
                int next = neighbor.Key;
                DFS(next, visited);
            }
        }
    }
}