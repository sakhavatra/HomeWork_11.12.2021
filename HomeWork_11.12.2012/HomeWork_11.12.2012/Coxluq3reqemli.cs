using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class Coxluq3reqemli
    {
        
         public  int Topla(int [] arr)
        {
            int result = 0;
            int sum3 = 0;
            int sumnot3 = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i]>99 && arr[i]<1000 || arr[i]<-99 && arr[i]>-1000 )
                {
                    sum3 = sum3 + arr[i];
                }
                else
                {
                    sumnot3 = sumnot3 + arr[i];  
                }
                result = sum3-sumnot3;

            }
                
            return result ;
            
        }
    }
}
