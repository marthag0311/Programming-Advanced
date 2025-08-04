namespace _09_Flights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nodes = Convert.ToInt32(Console.ReadLine());
                int edges = Convert.ToInt32(Console.ReadLine());

                Assignment assignment = new Assignment();

                int index = 0;
                while (index < edges)
                {
                    string[] array = Console.ReadLine().Split(",");
                    assignment.AddEdge(array[0].Trim(), array[1].Trim(), Convert.ToInt32(array[2].Trim()));
                    index++;
                }
                string departure = Console.ReadLine().Trim();
                string destination = Console.ReadLine().Trim();

                int result = assignment.Dijkstra(departure, destination);
                Console.WriteLine(result);
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