using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class CoxluqMinimum
    {
        public int index;

        public void hesabla()
        {
            int[] arr = new int[index];
            int i = 0, x = 0, enk;
            Console.Write(i + ".ededi daxil edin = ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            enk = arr[0];
            for (i = 1; i < index; i++)
            {
                Console.Write(i + ".ededi daxil edin = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (enk > arr[i])
                {
                    enk = arr[i];
                    x = i;
                }
            }

            Console.Write($" {enk} en kicik ededdir onun indeks nomresi {x} dir");
            Console.ReadLine();
        }

    }
}
