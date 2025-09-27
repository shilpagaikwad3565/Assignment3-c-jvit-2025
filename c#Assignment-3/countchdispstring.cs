using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{
    //16.count the number of character ,digits,spaces,and special characters in a string
    internal class countchdispstring
    {

        public void countcharstring()
        {
            string s = "radhaika @gaikwad 123";

            int character = 0; int digit = 0;int spaces = 0;int specichar = 0;

            for(int i=0; i<s.Length; i++)
            {
                char ch = s[i];
                if((ch>='a'&& ch<='z')||(ch>='A'&& ch<='Z'))
                {
                    character++;

                }
                else if(ch>='0'&&ch<='9')
                {
                    digit++;
                }

                else if(ch==' ')
                {
                    spaces++;
                }
                else
                {
                    specichar++;
                }
            }
            Console.WriteLine("total chracaters:" + character);
            Console.WriteLine("total digits:" + digit);
            Console.WriteLine("total spaces:" + spaces);
            Console.WriteLine("total specialcharacters:" + specichar);
                
        }
    }

}
