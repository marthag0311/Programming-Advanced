using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Module_11
{
    public class Assignment
    {
        private HashSet<string> words;

        public Assignment(string filename)
        {
            words = new HashSet<string>(File.ReadAllLines(filename).Select(w => w.ToLower()));
        }

        public List<int> Missing(int[] integers, int range)
        {
            HashSet<int> ints = new HashSet<int>(integers);

            List<int> missing = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                if (!ints.Contains(i)) missing.Add(i);
            }
            return missing;
        }

        public Tuple<string, int> DecryptCipher(string cipher)
        {
            for (int i = 1; i <= 25; i++)
            {
                string decryptedMessage = DecryptMessage(cipher, i);

                if (words.Contains(decryptedMessage.ToLower()))
                {
                    return Tuple.Create(decryptedMessage, i);
                }
            }
            return null;
        }

        private string DecryptMessage(string cipher, int shift)
        {
            char[] decryptedChars = new char[cipher.Length];
            for (int i = 0; i < cipher.Length; i++)
            {
                decryptedChars[i] = DecryptChar(cipher[i], shift);
            }
            return new string(decryptedChars);
        }

        private char DecryptChar(char character, int shift)
        {
            if (!char.IsLetter(character))
            {
                return character;
            }

            char baseChar = char.IsUpper(character) ? 'A' : 'a'; //if the character is upper, baseChar is set to 'A', otherwise 'a'
            return (char)((character - baseChar - shift + 26) % 26 + baseChar);
        }
    }
}