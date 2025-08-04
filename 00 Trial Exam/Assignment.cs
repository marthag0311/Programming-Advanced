using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace _00_Trial_Exam
{
    public class Assignment 
    {
        public string BruteForce(int[] array)
        {
            string output = "";                     

            Array.Sort(array);
            Array.Reverse(array);

            output += array[0];
            output += array[1];

            return output;
        }

        public int TeachersBruteForce(int[] array)
        {
            //Space complexity of the whole code = O(n^2)
            //List is used to store all possible combination of 2
            //elements from the array. The length of this list is 
            //determined by the number of pairs of elements, which is
            //(n * (n - 1)) / 2 for an array of length n. space
            //complexity is O((n * (n - 1)) / 2), simplified to O(n^2).
            //Each iteration of the inner loop adds a new element to 
            //the list, resulting in n * (n - 1) elements in total, 
            //results in space complexity beign quadratic in relation 
            //to the size of the input array.

            //Time complexity for the whole code = O(n^2)
            //uses 2 nested loops to consider all pairs of elements
            //in the array.

            int max = int.MinValue; //space & time complexity = O(1)
            List<int> numbers = new List<int>(); 

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        string nr = array[i].ToString() + array[j].ToString();
                        if (max < Convert.ToInt32(nr))
                        {
                            max = Convert.ToInt32(nr); //space & time complexity = O(1)
                        }
                        numbers.Add(Convert.ToInt32(nr));
                    }
                }
            }
            //numbers.Sort()
            //return numbers[numbers.Count - 1]
            //return numbers.Max()
            return max;
        }

        public int TeachersBruteForce(int[] array, int index, int max)
        {
            if (index == array.Length) return max;
            string digit1 = array[index].ToString();
            for (int i = 0; i < array.Length; i++)
            {
                string digit2 = array[i].ToString();
                int current = Int32.Parse(digit1 + digit2);
                if (current > max) max = current;
            }
            return TeachersBruteForce(array, ++index, max);
        }

        public string Greedy(int[] array)
        {
            string output = "";

            int first = int.MinValue; //space complexity 0(n) => 0(1), I might have heard the teacher wrong or she was wrong.
            int second = int.MaxValue;

            foreach (int number in array)
            {
                if (number > first)
                {
                    second = first;
                    first = number;
                }
                else if (number > second)
                {
                    second = number;
                }
            }
            output += first;
            output += second;
            return output;
        }

        public int TeachersGreedy(int[] array)
        {
            Array.Sort(array);
            int digit1 = array[array.Length - 1];
            int digit2 = array[array.Length - 2];
            return 0;
        }

        public int Linear(int[] array)
        {
            int max = Int32.MinValue;
            int semax = Int32.MinValue;

            foreach (int number in array)
            {
                if (number > max)
                {
                    semax = max;
                    max = number;
                }
                else if (number > semax)
                {
                    semax = number;
                }
            }
            return 0;
        }

        public Node Root { get; set; }

        public Assignment()
        {
            Root = null;
        }

        public Assignment(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null) Root = new Node(value);
            else Add(Root, value);
        }

        private void Add(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null) node.Left = new Node(value);
                else Add(node.Left, value);
            }
            else
            {
                if (node.Right == null) node.Right = new Node(value);
                else Add(node.Right, value);
            }
        }

        public string FindMax()
        {
            Node node = Root;

            string output = "";
            int first = int.MinValue;
            int second = int.MinValue;

            while (node.Right != null)
            {
                if (node.Value > first)
                {
                    second = first;
                    first = node.Value;
                }
                else if (node.Value > second)
                {
                    second = node.Value;
                }
                node = node.Right;
            }

            Console.WriteLine(first);
            Console.WriteLine(second);

            return output;
        }
    }
}