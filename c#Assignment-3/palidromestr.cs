using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{ //19.check if a string is a palidrome 
    internal class palidromestr
    {
        public void palidromestring()
        {
            string s = "madama";
            string rev = "";

            string temp = s;

            for(int i=s.Length-1;i>=0;i--)
            {
                rev += s[i];
            }
            if(s==rev)
            {
                Console.WriteLine("string is plaidrome");
            }
            else
            {
                Console.WriteLine("string is not plaidrome");
            }
        }
    }
}
