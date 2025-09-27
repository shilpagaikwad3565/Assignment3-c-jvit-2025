using System;

namespace c_Assignment_3
{
    // 24. remove duplicates characters from a string
    internal class removeduplichar
    {
        public void removeduplicates()
        {
            string s = "jvit programming assingment";
            string s2 = "";  // to store unique characters

            for (int i = 0; i < s.Length; i++)
            {
                bool found = false;

                // check if s[i] already exists in s2
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s[i] == s2[j])
                    {
                        found = true;
                        break;
                    }
                }

                // if not duplicate, add it to s2
                if (!found)
                {
                    s2 += s[i];
                }
            }

            Console.WriteLine("Original String: " + s);
            Console.WriteLine("After Removing Duplicates: " + s2);
        }
    }
}
eerty