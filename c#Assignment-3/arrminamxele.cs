using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    internal class arrminamxele
    {
//2.find the largest and smallest elements in array
        public void findingminmaxele()
        {
            int[] arr = { 100, 2, 3, 40, 5, 6, 7 };

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    
                }
                if(arr[i] < min)
                {
                    min=arr[i];
                  
                }


            }
            Console.WriteLine("max element in arr:" + max);
            Console.WriteLine("min element in arr:" + min);
        }
    }
}
