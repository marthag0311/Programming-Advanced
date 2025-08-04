namespace _12_Greedy_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scheduling activities = new Scheduling();

            /*
                 string[] classes = { "art", "eng", "math", "cs", "music"};
                 double[] start = { 9,9.5,10,10.5,11};
                 double[] end = { 10,10.5,11,11.5,12 };
             
             */

            /*activities.AddClass("art", 9, 10);
            activities.AddClass("eng", 9.5, 10.5);
            activities.AddClass("math", 10, 11);
            activities.AddClass("cs", 10.5, 11.5);
            activities.AddClass("music", 11, 12);

            Console.WriteLine(activities.ToString());

            List<Class> schedule = activities.Schedule();
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"class {i + 1}: {schedule[i].Name}");
            }*/

            Practice classes = new Practice();

            classes.AddClass("art", 9, 10);
            classes.AddClass("eng", 9.5, 10.5);
            classes.AddClass("math", 10, 11);
            classes.AddClass("cs", 10.5, 11.5);
            classes.AddClass("music", 11, 12);

            Console.WriteLine(classes.ToString());

            List<Subject> schedule = classes.Scheduling();

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"class {i + 1}: {schedule[i].Name}");
            }
        }
    }
}