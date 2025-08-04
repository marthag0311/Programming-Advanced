using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Module_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();

            string input;
            while ((input = Console.ReadLine()) != null)
            {
                input = input.Trim();
                bool isNotCrazy = true;

                string[] line = input.Split();
                if (line.Length < 2)
                {
                    Console.WriteLine("Crazy input!");
                    continue;
                }

                char character = line[0][0];

                for (int i = 1; i < line.Length; i++)
                {
                    if (!Int32.TryParse(line[i], out int value))
                    {
                        Console.WriteLine("Crazy input!");
                        isNotCrazy = false;
                        break;
                    }

                    if (character == 'A') tree.Add(value);
                    else tree.Delete(value);
                }
                if (isNotCrazy) tree.TraverseInOrder();
            }
        }
    }
}