using System;

namespace c_Assignment_3
{
    // 22. find the frequency of each character in a string
    internal class freqstring
    {
        public void findfreqofchar()
        {
            string s = "shilpagaikwad";
            bool[] visited = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (visited[i])  // skip if already counted
                    continue;

                int count = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                        visited[j] = true; // mark duplicate as visited
                    }
                }

                Console.WriteLine(s[i] + " = " + count);
            }
        }
    }
}
