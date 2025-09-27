using System;

namespace c_Assignment_3
{//30 reverse the order of words in dsentense
    internal 
        class reverseordersen
    {
        public void reverseWords()
        {
            string sentence = "I am learning C#";

            string[] words = new string[50]; // store words manually
            int wordCount = 0;
            string word = "";

            // Step 1: Break sentence into words manually
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    word = word + sentence[i];
                }
                else
                {
                    words[wordCount] = word;
                    wordCount++;
                    word = "";
                }
            }
            // add last word
            if (word != "")
            {
                words[wordCount] = word;
                wordCount++;
            }

            // Step 2: Print words in reverse order
            Console.WriteLine("Reversed sentence:");
            for (int i = wordCount - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
