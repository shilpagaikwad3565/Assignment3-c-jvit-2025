using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{ //6.sort an array in ascending and descending order
    internal class sorttingarr
    {
        int[] arr = { 10, 30, 50, 60, 90, 40, 20 };
        public void sortingarrinascendingorder()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        
                    }

                }
               
            }
            Console.WriteLine("ascending order:" );
            foreach (int a in arr)
            {
                Console.WriteLine(a + " ");
            }
         }

        public void sortingarrindescendingorder()
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j =i+1;j<arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];            
                        arr[j] = temp;
                    }

                }
            }

            Console.WriteLine("descending order:");
            foreach(int a in arr)
            {
                Console.WriteLine(a + " "); 
            }
        }
    }
}
