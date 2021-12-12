using System;

namespace HomeWork_11._12._2012
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region 1.Class yaradın metod yazın içərisində.Ədədin 2-nin qüvvəti olub olmadığını tapsın.
            Console.WriteLine("\n****************************Task-1****************************\n");
            Quvvet2 check = new Quvvet2();
            Console.Write("2 nin quvveti olub olmadigini yoxlamaq ucun\n-->>Eded daxil edin = ");
            check.num = Convert.ToInt32(Console.ReadLine());
            check.Yoxla();
            #endregion



            
            #region 2.Class yaradın.Metod olsun içərisində.Arrayın minimum elementini və indeksini ekrana çıxarsın.
            Console.WriteLine("\n****************************Task-2****************************\n");
            CoxluqMinimum coxluqMinimum = new CoxluqMinimum();
            Console.Write("Coxluqda En kicik ededi ve onun indeksini tapmaq ucun\nCoxluqun indeks sayini daxil edin= ");
            coxluqMinimum.index = int.Parse(Console.ReadLine());
            coxluqMinimum.hesabla();
            #endregion




            
            #region 3.Arrayda 3 rəqəmli ədədlərin cəmi ilə digər ədədlərin cəmi arasındakı fərqi tapan algorithm qurun
            Console.WriteLine("\n****************************Task-3****************************\n");
            Console.Write("Coxluqda 3 reqemli ededlerin cemi ile 3 reqemli olmayan ededlerin ceminin  ferqini tapmaq ucun\nCoxluqun indeks sayini daxil edin= ");
            int index = int.Parse(Console.ReadLine());
            int[] arr = new int[index];
            int i = 0;
            for (i = 0; i < index; i++)
            {
                Console.Write(i + ".ededi daxil edin = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Coxluq3reqemli array = new Coxluq3reqemli();
            Console.WriteLine("-->>Coxluqda 3 reqemli ededlerin cemi ile  3 reqemli olmayan ededlerin ceminin  ferqi=" + array.Topla(arr));
            #endregion



            
            #region 4. write a program in c# to count the total number of words in a string.
            Console.WriteLine("\n****************************Task-4****************************\n");
            Console.WriteLine("-->> Write a program in c# to count the total number of words in a string");
            Console.Write("Input the string = ");
            string word = Console.ReadLine();

            SozSay wordcount = new SozSay();
            wordcount.count(word);

            #endregion




            
            #region Write a program in c# to find the number of times a given  word "the" appears in the given string
            Console.WriteLine("\n****************************Task-5****************************\n");
            Console.WriteLine("Write a program in c# to find the number of times a given  word the appears in the given string");

            Console.Write("Input the string = ");
            string cumle = Console.ReadLine();

            Console.Write("Input the string = ");
            string soz = Console.ReadLine();

            SozTap countTheWord = new SozTap();
            countTheWord.cumle = cumle;
            countTheWord.soz = soz;

            Console.Write($"The frequency of the word '{countTheWord.soz}' is: " + countTheWord.Hesapla());
            Console.ReadLine();
            #endregion




            
            #region 10 elementli Array elementlerinin sondan evvele dogru cap edilmesi
            Console.WriteLine("\n****************************Task-6****************************\n");
            Console.WriteLine("10 elementli Array elementlerinin sondan evvele dogru cap edilmesi");
            Coxluqlar coxluqSirala = new Coxluqlar();
            coxluqSirala.Sirala();
            #endregion





            
            #region Eyni uzunluqda iki Array yarat ve onlari birlesdir ve yaranmis Arrayi boyukden kiciye ekrana cap et
            Console.WriteLine("\n****************************Task-7****************************\n");
            Coxluqlar birlesdir = new Coxluqlar();
            birlesdir.Birlesdir();
            #endregion




            
            #region Arrayda Minimum ve Maksimum elementleri cap et
            Console.WriteLine("\n****************************Task-8****************************\n");
            Console.WriteLine("\nArrayda Minimum ve Maksimum elementleri cap et\n");
            Coxluqlar min_max = new Coxluqlar();
            min_max.min_max();
            #endregion




            
            #region 10 elementden ibaret array yaradin bu arrayin tek elementlerini ve cut elementlerini ferqli arraylara elave ederek ayriliqda cap edin
            Console.WriteLine("\n****************************Task-9****************************\n");
            Coxluqlar tekcut = new Coxluqlar();
            tekcut.tek_cut();
            #endregion

            
            #region Student clasi yarat 
            Console.WriteLine("\n****************************Task-10****************************\n");
            Students students = new("Saxavat Aliyev", "Graduated", "Computer Engineering", "Baku Engineering University", "s.r.eliyev@asan.gov.az",99773009936);
            Console.WriteLine(students.InfoMetod());

            #endregion


            Console.ReadLine();
        }

    }
}
