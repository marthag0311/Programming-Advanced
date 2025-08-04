using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04_Recursion
{
    internal class FindKey
    {
        public string BaseFolder { get; set; }
        public int Count { get; set; }

        public FindKey(string baseFolder)
        {
            BaseFolder = baseFolder;
        }

        public string Algorithm1()
        {
            Queue<string> folders = new Queue<string>();
            folders.Enqueue(BaseFolder); //add to Queue
            while (folders.Count > 0) //add everything to a list, the moment you find you break it
            {
                Count++;

                string folder = folders.Dequeue(); //

                if (Directory.Exists(folder))
                {
                    if (Directory.GetFiles(folder).Length > 0) return folder;

                    foreach (string item in Directory.GetDirectories(folder))
                        folders.Enqueue(item);
                }

            }
            return "not found";
        }

        public string Algorithm2(string folder) 
        {
            /*
             * Check 
             * if it is a box return to step 1
             * if it is a file
             */

            Count++;

            foreach (string item in Directory.EnumerateFileSystemEntries(folder))
            {
                Console.WriteLine("CALL TO METHOD");

                if (Directory.Exists(item))
                {
                    string result = Algorithm2(item);
                    if (result != "not found") return result;
                }
                if (File.Exists(item))
                {
                    Console.WriteLine("FILE");
                    return item;
                }
            }
            return "not found";            
        }    
    }
}
