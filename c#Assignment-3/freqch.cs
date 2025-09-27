using System;

namespace c_Assignment_3
{//12.find the frequency of each elemnet in array
    internal class freqch
    {
        public void findingfrequencyofele()
        {
            int[] arr = { 10, 20, 30, 20, 10, 30, 40 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1) // already counted, skip
                    continue;

                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1; // mark as counted
                    }
                }

                Console.WriteLine(arr[i] + " occurs " + count + " times");
            }
        }
    }
}
