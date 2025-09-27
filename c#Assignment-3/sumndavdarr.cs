using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    //3.find the sum and average of array elements
    internal class sumndavdarr
    {
        int[] arr = { 12, 3, 4, 5, 77, 8 };
        int sum = 0;
        public void findingsumofarray()
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                sum=sum+arr[i];
            }

            Console.WriteLine("sum of array elements:" + sum);
        }

        public void findingavgofele()
        {
            double avg = (double)sum / arr.Length;
            Console.WriteLine("average of elements:" + avg);

        }
    }
}
