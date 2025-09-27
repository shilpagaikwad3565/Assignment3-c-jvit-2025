using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    internal class evenodd
    { //4.count how many numbers are even and odd in array.
        public void findingevenoddele()
        {

            int[] arr = { 2, 4, 5, 6, 7, 8, 9 };

            int even=0, odd=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    even++;
                }
                else 
                {
                    odd++;
                }
                
            }
            Console.WriteLine("even numebrs:" + even);
            Console.WriteLine("even numebrs:" + odd);

        }
    }
}
