using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{                         //1.input ten numbers in an array and print them
    internal class array1demo
    {
        public void printingarrayele()
        {

            int[] arr = new int[10];
            Console.WriteLine("enter array elements:");

            for (int i = 0; i <arr.Length; i++)
            {

                arr[i]=int.Parse(Console.ReadLine());



            }

            Console.WriteLine("array elements are:");

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
