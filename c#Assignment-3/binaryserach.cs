using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace c_Assignment_3
{
    //15.implement binary search on a soretd array.
    internal class binaryserach
    {
        public void implementringbinarysearch(int n)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;
            bool found = false;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if(mid==n)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    found = true;
                    break;
                }
                if (arr[mid]<=n)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if(!found)
            {
                Console.WriteLine("Element not found!");
            }


        }
    }
}
