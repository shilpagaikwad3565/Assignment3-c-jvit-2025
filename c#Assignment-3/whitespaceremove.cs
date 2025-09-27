using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{//23.remove all white spaces from a string 
    internal class whitespaceremove
    {
        public void removingwhitespacesfmstring()
        {
            string s = "radha patil laturkar";

            char c = ' ';
            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                c= s[i];
                if( c!= ' ' )
                {
                    res += c;
                }
            }
            Console.WriteLine(res);
        }
    }
}
