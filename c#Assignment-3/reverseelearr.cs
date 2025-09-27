using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    //5.reverse the elements of an array
    internal class reverseelearr
    {
        public void reversearrayele()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("original array elements:");

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("reverse array elements:");
            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.Write(arr[i]+" ");

            }

            }
    }
}
