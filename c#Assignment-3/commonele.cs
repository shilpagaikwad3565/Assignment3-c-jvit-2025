
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{//14.find  the common elements between two arrays
    internal class commonele
    {
        public void findingcommonele()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 2, 4, 5, 7, 8 };

            for(int i=0;i<arr1.Length;i++)
            {
                for(int j=0;j<arr2.Length;j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                        break;
                    }
                }
            }
        }

    }
}
