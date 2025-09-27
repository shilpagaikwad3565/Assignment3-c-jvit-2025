using System;

namespace c_Assignment_3
{
    // 13. Copy all even numbers into one array and odd numbers into another
    internal class evenoddcopy
    {
        int[] arr = { 1, 2, 4, 6, 5, 7, 9 };

        public void findingevenoddnumbers()
        {
            int n = arr.Length;
            int[] evenarr = new int[n];
            int[] oddarr = new int[n];


            int eindex = 0, oindex = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)   // even
                {
                    evenarr[eindex] = arr[i];
                    eindex++;
                }
                else                   // odd
                {
                    oddarr[oindex] = arr[i];
                    oindex++;
                }
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < eindex; i++)
            {
                Console.Write(evenarr[i] + " ");
            }

            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < oindex; i++)
            {
                Console.Write(oddarr[i] + " ");
            }
        }
    }
}

