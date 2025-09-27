using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    //8.Merge two arrys into single array
    internal class mergearr
    {
        public void mergingarrinsingle()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };

            int[] merge =new int[arr1.Length+ arr2.Length];
            int k = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                merge[k] = arr1[i];
                k++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                merge[k] = arr2[i];
                k++;
            }

            Console.WriteLine("merged array:");
          for(int i=0;i<merge.Length;i++)
            {
                Console.WriteLine(merge[i] + " ");
            }

        }

    }
}
