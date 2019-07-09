using System;

namespace ThirdDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y= 3;

            Swap(ref x, ref y);
            Console.WriteLine("x : {0} , y :{1}" ,x ,y);
           


    }

        public static void Swap( ref int x ,ref  int y)
        {


            int temp = x;
            x = y;
            y = temp;

        }
    }
    // (int num)
    //int temp = x;
    //x = y;
    //y = temp;


    //int temp = num;

    //double z=num;
    //int x = 0;
    //for (int i = 0; temp != 0; i++)
    //{
    //    z = (double)temp / 10;
    //    temp /= 10;

    //    z = (z - temp)*10;
    //    x = x * 10 + (int)z;

    //int p = 1;
    //if (y > 0)
    //{
    //    p = x * power(x, y - 1);
    //}
    //return p;

    //}
}
