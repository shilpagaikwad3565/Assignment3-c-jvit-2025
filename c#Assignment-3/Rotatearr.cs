using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    //11.rotate an array  left/right by N position
    internal class Rotatearr
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        
        public void leftrotatearr(int n)
        {
            int length = arr.Length;
            for (int i = 0; i < n; i++)
            {
               
                int first = arr[0];

                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[length - 1] = first;
            }
            Console.WriteLine("after Left rotate:");
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");
            }
            
        }
        public void rightrotate(int n)
        {
            int length = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int last = arr[length - 1];

                for(int j=length-1; j>0; j--)
                {
                    arr[j] = arr[j - 1];
                    
                }
                arr[0] = last;
            }
            Console.WriteLine("after right rotate:");
            foreach(int r in arr)
            {
                Console.WriteLine(r+" ");
            }
        }

    }
}
