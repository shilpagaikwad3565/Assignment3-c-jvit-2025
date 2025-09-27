using System;

namespace c_Assignment_3
{
    internal class dupliwordcount
    {//29.count duplicate words in a sentence
        public void countduplicatewordsinstr()
        {
            string sentence = "this is a test this is code";

            // store words manually
            string[] words = new string[50];
            int wordCount = 0;
            string word = "";

            // break sentence into words
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

            // check duplicates
            for (int i = 0; i < wordCount; i++)
            {
                if (words[i] == null) continue;

                int count = 1;

                for (int j = i + 1; j < wordCount; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;
                        words[j] = null; // mark duplicate
                    }
                }

                if (count > 1) // print only duplicates
                {
                    Console.WriteLine(words[i] + " = " + count);
                }
            }
        }
    }
}
