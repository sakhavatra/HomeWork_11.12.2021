using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class Quvvet2
    {
        public int num;
        public void Yoxla()
        {
            while (num % 2 == 0)
            {
                num = num / 2;
            }
            if (num == 1)
            {
                Console.WriteLine("-->>daxil edilen eded 2-in quvvetidir");
            }
            else
            {
                Console.WriteLine("-->>daxil edilen eded 2-in quvveti deyil");
            }
            Console.ReadLine();
        }
    }
}