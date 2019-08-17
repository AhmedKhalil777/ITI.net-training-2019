using System;

namespace _1to99_999_999
{
    class Program
    {
        static void Main(string[] args)
        {
            int occuring = 0;
            for (int i = 1; i < 99999999; i++)
            {
                occuring += Occur(i, '1');
            }
            System.Console.WriteLine($"The occurance of 1 is {occuring}");
            
        }

// return occurance of a num in a num
        static int Occur(int num , char ch)
        {
            int oc = 0 ;
           foreach (var item in num.ToString())
           {
               if (item == ch)
               {
                   oc ++;
               }
           }
           return oc ;
        }
    }
}
