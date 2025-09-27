using System;

namespace c_Assignment_3
{
    // 27. find the first non-repeated character in a string
    internal class nonrepeatchar
    {
        public void findingnonrepeatedchar()
        {
            string s = "mdamasi";
            char ch = ' ';
            bool found = false;

            for (int i = 0; i < s.Length; i++)
            {
                bool isRepeated = false;

                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j]) // if same char found at diff index
                    {
                        isRepeated = true;
                        break;
                    }
                }

                if (!isRepeated) // first non-repeated found
                {
                    ch = s[i];
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("First non-repeated char: " + ch);
            else
                Console.WriteLine("No non-repeated character found");
        }
    }
}
