using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class Coxluqlar
    {
        public void Sirala()
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("\n 10 elementli Arrayin elementlerini daxil edin\n");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(i + ".elementi daxil edin = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nArrayin elementlerinin sondan evvele dogru ekrrana cap edilmesi\n");
            for (int a = arr.Length - 1; a >= 0; a--)
            {
                Console.WriteLine(arr[a]);
            }

            Console.ReadLine();
        }

        public void Birlesdir()
        {
            Console.WriteLine("Eyni uzunluqda iki Array yarat ve onlari birlesdir ve yaranmis Arrayi boyukden kiciye ekrana cap et\n");
            
            Console.Write("Arrayin uzunluqunu daxil edin=");
            int uzunuq = int.Parse(Console.ReadLine());

            int[] arr1 = new int[uzunuq];
            int i1;

            Console.Write("\n1 ci Array elementlerini daxil edin\n");
            for (i1 = 0; i1 < arr1.Length; i1++)
            {
                Console.Write(i1 + ".elementi daxil edin = ");
                arr1[i1] = int.Parse(Console.ReadLine());
            }

            int[] arr2 = new int[uzunuq];
            int i2;

            Console.WriteLine("\n2 ci Array elementlerini daxil edin\n");

            for (i2 = 0; i2 < arr2.Length; i2++)
            {
                Console.Write(i2 + ".elementi daxil edin = ");
                arr2[i2] = int.Parse(Console.ReadLine());
            }

            int[] arryekun = new int[uzunuq * 2];
            int i3;

            for (i3 = 0, i1 = 0, i2 = -arr2.Length; i3 < arryekun.Length; i3++, i1++, i2++)
            {
                if (i3 < arr1.Length)
                {
                    arryekun[i3] = arr1[i1];
                }
                else
                    arryekun[i3] = arr2[i2];
            }


            Console.WriteLine("\n2 arrayin birlesmesinden yaradilmis 3 cu arrayin elementlerinin boyukden kiciye dogru sirasi\n");
            Array.Sort(arryekun);
            Array.Reverse(arryekun);
            foreach (int deyer in arryekun)
            {

                Console.WriteLine(deyer);
            }

        }

        public void min_max ()
        {
            Console.Write("Arrayin olcusunu daxil edin=");
            int index = int.Parse(Console.ReadLine());

            int enb, enk, i = 0;
            int[] arr3 = new int[index];
            Console.Write(i + ".Elementi daxil edin =");
            arr3[i] = Convert.ToInt32(Console.ReadLine());
            enb = arr3[i];
            enk = arr3[i];
            for (i = 1; i < index; i++)
            {
                Console.Write(i + ".Elementi daxil edin =");
                arr3[i] = Convert.ToInt32(Console.ReadLine());
                if (arr3[i] > enb)
                {
                    enb = arr3[i];

                }
                if (arr3[i] < enk)
                {
                    enk = arr3[i];

                }
            }

            Console.WriteLine("Arrayin en boyuk elementi=" + enb);
            Console.WriteLine("Arrayin en kicik elementi=" + enk);

            Console.ReadLine();

        }

        public void tek_cut()
        {
            Console.WriteLine("10 elementden ibaret array yaradin bu arrayin tek elementlerini ve cut elementlerini\nferqli arraylara elave ederek her ikisini  cap edin\n");
            Console.WriteLine("10 elementli Arrayin elementlerini daxil edin\n");
            int[] arr = new int[10];
            int i;

            int arrCindex = 0;
            int arrTindex = 0;
            int arrSifirindex = 0;

            for (i = 0; i <arr.Length; i++)
            {
                Console.Write(i + ".elementi daxil edin = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i]!=0 )
                {
                    arrCindex = arrCindex + 1;
                }
                else
                   if (arr[i]%2!=0 && arr[i] != 0)
                {
                    arrTindex = arrTindex + 1;
                }
                else
                {
                    arrSifirindex = arrSifirindex + 1;
                }


            }

            int[] arrTek = new int[arrTindex];
            int[] arrCut = new int[arrCindex];
            int[] arrSifir = new int[arrSifirindex];

            int m;
            int t;
            int c;
            int s;

            for (m = 0, t = 0, c = 0, s=0; m < arr.Length; m++)
            {
                if (arr[m] % 2 == 0 && arr[m]!=0)
                {
                    arrCut[c] = arr[m];
                    c++;
                }
                else
                   if (arr[m]%2!=0 && arr[m] != 0)
                {
                    arrTek[t] = arr[m];
                    t++;
                }
                else
                {
                    arrSifir[s] = arr[m];
                    s++;
                }

            }

            Console.WriteLine($"\n**********Arraya daxil olan cut elementlerin sayi: {arrCindex} **********\n");
            for (int a1 = 0; a1 < arrCut.Length; a1++)
            {
                Console.WriteLine(arrCut[a1]);
            }


            Console.WriteLine($"\n**********Arraya daxil olan tek elementlerin sayi: {arrTindex} **********\n");

            for (int a2 = 0; a2 < arrTek.Length; a2++)
            {
                Console.WriteLine(arrTek[a2]);
            }

            Console.WriteLine($"\n**********Arraya daxil olan 0 -larin sayi: {arrSifirindex} **********\n");

            for (int a3 = 0; a3 < arrSifir.Length; a3++)
            {
                Console.WriteLine(arrSifir[a3]);
            }

            Console.ReadLine();

        }

    }
}
