using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Assignment_3
{//21.count the number of words in string
    internal class wordcount
    {
        public void countwordinstr()
        {
            string s1 = "Hello im shilpa gaikwad";
            int count=0;
            bool word= false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i]!=' '&&!word)
                {
                    word = true;
                    count++;
                }
                else if (s1[i]==' ')
                {
                    word = false;
                }
            }
            Console.WriteLine("words in string:" + count);
        }
    }
}
