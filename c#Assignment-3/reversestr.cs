using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{//18.reverse astring  without using built-in methods
    internal class reversestr
    {
        public void reversestring()
        {
            string str = "radhika";
            string rev = "";
            Console.WriteLine("original string:" + str);

            for(int i=str.Length-1;i>=0;i--)
            {
                rev += str[i];
            }
            Console.WriteLine("reverse string:" + rev);
           
        }

    }
}
