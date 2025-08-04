using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Search___Intro_Big_O
{
    internal class Practice
    {
        public int attempts { get; set; }
        public int Target { get; set; }
        public int[] Array { get; set; }

        public Practice(int target, int[] array)
        {
            this.Target = target;
            this.Array = array;
        }

        public int Linear ()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                attempts++;
                if (Array[i] == Target)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Binary()
        {
            attempts = 0;
            int start = 0;
            int end = Array.Length - 1;

            while (start <= end)
            {
                attempts++;
                int mid = (end - start) / 2;

                if (Target == Array[mid]) return mid;
                else if (Target > Array[mid]) start = mid + 1;
                else if (Target < Array[mid]) end = mid - 1;
            }
            return -1;
        }

        public int Stupid()
        {        
            attempts = 0;
            int max_attempts = Array.Length * 30;
            Random random = new Random();

            while (attempts < max_attempts)
            {
                attempts++;
                int index = random.Next(0, Array.Length);

                if (Target == Array[index]) return index;                
            }
            return -1;
        }
    }
}
