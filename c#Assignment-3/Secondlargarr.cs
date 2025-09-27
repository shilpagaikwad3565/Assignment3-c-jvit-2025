using System;

namespace c_Assignment_3
{ //9. finding second largest element in array
    internal class Secondlargarr
    {
        public void findingsecondlargele()
        {
            int[] arr = { 10, 20, 30, 50, 60, 70 };

           

            int max, secondmax;

            // Initialize max and secondmax using first two elements
            if (arr[0] > arr[1])
            {
                max = arr[0];
                secondmax = arr[1];
            }
            else
            {
                max = arr[1];
                secondmax = arr[0];
            }

            // Process remaining elements
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondmax = max;  // old max becomes secondmax
                    max = arr[i];     // new max found
                }
                else if (arr[i] > secondmax && arr[i] != max)
                {
                    secondmax = arr[i]; // arr[i] is between max and secondmax
                }
            }

            
                Console.WriteLine("Second largest element: " + secondmax);
            
        }
    }
}
