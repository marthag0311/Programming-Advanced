namespace _09_Flights
{
    internal class Assignment
    {
        private List<Tuple<string, string, int>> graph;

        public Assignment()
        {
            graph = new List<Tuple<string, string, int>>();
        }

        public void AddEdge(string node1, string node2, int weight)
        {
            graph.Add(new Tuple<string, string, int>(node1, node2, weight));
        }

        public int Dijkstra(string departure, string destination)
        {
            Dictionary<string, int> costs = new Dictionary<string, int>();
            Dictionary<string, string> previous = new Dictionary<string, string>();
            List<string> visited = new List<string>();

            // Initialize costs
            foreach (var city in UniqueCities())
            {
                costs[city] = int.MaxValue; // Initialize to int.MaxValue for minimum cost
                previous[city] = null;
            }

            costs[departure] = 0;

            while (true)
            {
                string current = GetNextCity(costs, visited);

                if (current == null || current == destination)
                {
                    break;
                }

                visited.Add(current);

                foreach (var edge in graph)
                {
                    if (edge.Item1 == current)
                    {
                        string neighbor = edge.Item2;
                        int cost = costs[current] + edge.Item3;

                        if (cost < costs[neighbor])
                        {
                            costs[neighbor] = cost;
                            previous[neighbor] = current;
                        }
                    }
                }
            }
            return costs[destination];
        }

        private string GetNextCity(Dictionary<string, int> costs, List<string> visited)
        {
            string next = null;
            int min = int.MaxValue;

            foreach (var city in costs.Keys)
            {
                if (!visited.Contains(city) && costs[city] < min)
                {
                    min = costs[city];
                    next = city;
                }
            }
            return next;
        }

        private IEnumerable<string> UniqueCities()
        {
            HashSet<string> uniqueCities = new HashSet<string>();
            foreach (var edge in graph)
            {
                uniqueCities.Add(edge.Item1);
                uniqueCities.Add(edge.Item2);
            }
            return uniqueCities;
        }
    }
}