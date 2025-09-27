using System;

namespace c_Assignment_3
{
    // 28. find all permutations of a string
    internal class permutationstr
    {
        public void findPermutations(string str)
        {
            permute(str, 0, str.Length - 1);
        }

        private void permute(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
            }
            else
            {
                char[] charArray = str.ToCharArray();

                for (int i = left; i <= right; i++)
                {
                    // swap characters
                    swap(charArray, left, i);

                    // recurse
                    permute(new string(charArray), left + 1, right);

                    // backtrack (swap again to restore original string)
                    swap(charArray, left, i);
                }
            }
        }

        private void swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

