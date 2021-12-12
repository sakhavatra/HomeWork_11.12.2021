using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class SozSay
    {
        public void count(string word)
        {


            int result = 0;
            int i = 0;
            char ch = ' ';

            while (i < word.Length)
            {
                while (i < word.Length && word[i] != ch)

                    i++;

                result = result + 1;

                while (i < word.Length && word[i] == ch)

                    i++;
            }
            Console.WriteLine("Total number of words in the string is= " + result);
            Console.ReadLine();


        }
    }
}
