using System;

namespace c_Assignment_3
{
    // 26. check if two strings are anagrams
    internal class stringanagrams
    {
        public void checkingstringanagrams()
        {
            string s = "listen";
            string s1 = "silent";

            if (s.Length != s1.Length)
            {
                Console.WriteLine("Strings are not anagrams (different lengths)");
                return;
            }

            bool[] visited = new bool[s1.Length]; // to mark matched chars
            bool isAnagram = true;

            for (int i = 0; i < s.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s[i] == s1[j] && !visited[j])

                    {
                        visited[j] = true; // mark this char as used
                        found = true;
                        break;
                    }
                }

                if (!found) // if any character not found, not anagram
                {
                    isAnagram = false;
                    break;
                }
            }

            if (isAnagram)
                Console.WriteLine("Strings are anagrams");
            else
                Console.WriteLine("Strings are not anagrams");
        }
    }
}

