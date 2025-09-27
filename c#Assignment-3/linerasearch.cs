using System;

namespace c_Assignment_3
{
    //7. search for an element in an array (linear search)
    internal class linerasearch
    {
        public void searchelement()
        {
            int[] arr = { 10, 3, 405, 60, 80, 70 };
            Console.WriteLine("Enter an element to search:");
            int search = int.Parse(Console.ReadLine());

            int found = 0; // flag

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("Element found: " + arr[i]);
                    found = 1;
                    break;  // stop after finding
                }
            }

            if (found == 0) // only print if not found after checking all elements
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
