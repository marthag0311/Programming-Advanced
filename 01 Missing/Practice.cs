using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Missing
{
    internal class Practice
    {
        public int[] array { get; set; }

        public Practice(int[] array)
        {
            this.array = array;
        }

        public string BruteForce()
        {
            int[] unique = array.Distinct().ToArray();

            int count = unique[0];

            for (int i = 0; i < unique.Length; i++)
            {
                if (count == unique[i])
                {
                    count++;
                }
                else return count.ToString();
            }

            return "No missing number";
        }        
    }
}
