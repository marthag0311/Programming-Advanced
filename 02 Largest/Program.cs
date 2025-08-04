namespace _02_Largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string start = Console.ReadLine();

                Assignment assignment = new Assignment();
                Console.WriteLine(assignment.Read(start));
            }
            catch (FormatException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Crazy input!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}