using System;

namespace c_Assignment_3
{
    // 25. find the longest word in a given string
    internal class longestword
    {
        public void findinglongestword()
        {
            string s = "shilpa gaikwad im from latur.";
            string longest = "";   // to store the longest word
            string current = "";   // to build each word

            for (int i = 0; i < s.Length; i++)
            {
                // if current character is not space or punctuation, add it to current word
                if (s[i] != ' ' && s[i] != '.')
                {
                    current += s[i];
                }
                else
                {
                    // check if current word is longest so far
                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                    current = ""; // reset for next word
                }
            }

            // check last word in case it is longest
            if (current.Length > longest.Length)
            {
                longest = current;
            }

            Console.WriteLine("Original string: " + s);
            Console.WriteLine("Longest word: " + longest);
            Console.WriteLine("Length of longest word: " + longest.Length);
        }
    }
}
