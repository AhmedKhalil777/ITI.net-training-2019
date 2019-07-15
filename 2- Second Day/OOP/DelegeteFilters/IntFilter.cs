using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DelegeteFilters
{

    delegate bool intFilter(int num);
    class IntFilter
    {

      

        public static int[] filter( int[] arr  ,intFilter filter)
        {
            ArrayList Arr = new ArrayList();
            foreach (var item in arr)
            {
                if (filter(item))
                {
                    Arr.Add(item);
                }
            }
            return  (int[])Arr.ToArray(typeof(int));
        }

        

    }
}
