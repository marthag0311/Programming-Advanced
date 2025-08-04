using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Nth_Character
{
    internal class Assignment
    {
        public string NthCharacter(int number, string filename)
        {
            string[] words = File.ReadAllLines(filename);
            string text = string.Join("", words);

            if (number < 0)
            {
                return "Crazy input!";
            }

            char character = text[number];

            return character.ToString();
        }

        public char BruteForce(int number, string filename)
        {
            string[] words = File.ReadAllLines(filename);
            string text = string.Join("", words);
            char character = text[number];
            return character;
        }

        public string LinearSearch(int number, string filename)
        {
            string[] words = File.ReadAllLines(filename);
            string text = string.Join("", words);

            for (int i = 0; i < text.Length; i++)
            {
                if (i == number) return text[i].ToString();
            }
            return "Crazy input!";
        }

        public string BinarySearch(int number, string filename)
        {
            string[] words = File.ReadAllLines(filename);
            string text = string.Join("", words);

            int start = 0;
            int end = text.Length - 1;

            while (start <= end)
            {
                int mid = end - start / 2;

                if (mid == number) return text[mid].ToString();
                else if (number > mid) start = mid + 1;
                else end = mid - 1;
            }

            return "Crazy input!";
        }

        public string StupidSearch(int number, string filename)
        {
            string[] words = File.ReadAllLines(filename);
            string text = string.Join("", words);

            int start = 0;
            int end = text.Length * 2;
            Random random = new Random();

            while (start <= end)
            {
                start++;
                int index = random.Next(0, text.Length);

                if (index == number) return text[index].ToString();
            }
            return "Crazy input!";
        }
    }
}
