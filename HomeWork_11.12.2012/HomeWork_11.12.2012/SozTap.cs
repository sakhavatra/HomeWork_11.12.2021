using System;
using System.Linq;

namespace HomeWork_11._12._2012
{
    class SozTap
    {
        public string cumle;
        public string soz;
        public int Hesapla()
        {
            int result = 0;

            string cumlekicik = cumle.ToLower();
            string sozkicik = soz.ToLower();
            string[] sozayir = cumlekicik.Split(' ');

            for (int i = 0; i < sozayir.Length; i++)
            {
                if (sozayir[i] == sozkicik)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
