using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{ //17.count the number of vowels and constants in string
    internal class vovelconststr
    {
        public void countingvowelsconst()
        {
            string s = "shilpagaikwad";
            char ch;
            int vowels = 0;
            int constant = 0;

            for(int i=0;i<s.Length;i++)
            {
                ch = s[i];
                if(ch=='a')
                {
                    vowels++;
                }
                else if(ch=='e')
                {
                    vowels++;
                }
                else if (ch == 'i')
                {
                    vowels++;
                }
                else if (ch == 'o')
                {
                    vowels++;
                }
                else if (ch == 'u')
                {
                    vowels++;
                }
                else
                {
                    constant++;
                }
            }

            Console.WriteLine("vowel are:" + vowels);
            Console.WriteLine("constant are:" + constant);
        }
    }
}
