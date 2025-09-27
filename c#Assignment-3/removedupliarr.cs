using System;

namespace c_Assignment_3
{
    // 10. Remove duplicates from array
    internal class removedupliarr
    {
        public void removedupliele()
        {
            int[] arr = { 1, 2, 3, 4, 5, 2, 1, 6, 7, 6 };

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                // check only previous elements
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // print if not duplicate
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
