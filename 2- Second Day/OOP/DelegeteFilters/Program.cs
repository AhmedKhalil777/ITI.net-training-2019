using System;
using System.Collections.Generic;
namespace DelegeteFilters
{
    interface IAerea
    {
        double Area();
    }
    class rect:IAerea
    {
        int x, y;
        public int X
        {
            set
            { x = value; }
            get { return x; }
        }
        public int  Y
        {
            set
            { y= value; }
            get { return y; }
        }
        public double Area()
        {
            return  x * y;
            Console.WriteLine("rect");
        }
    }
    class ciric:IAerea
    {
        int x, y;

        public int X { get => x; set => x = value; }
       
        public int Y { get => y; set => y = value; }

        public double Area()
        {
            return x * y;
            Console.WriteLine("circ");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            rect rr = new rect { X = 9, Y = 8 };
            ciric c = new ciric { X = 4, Y = 6 };
             double x=ClcArea(c);
            Console.WriteLine(x);
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //int[] Odds = IntFilter.filter(arr, b => b % 2 == 1);
            //int[] evens = IntFilter.filter(arr, b => b % 2 == 0);
      
            //Console.WriteLine("Even Set");
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Odd Set");
            //foreach (var item in Odds)
            //{
            //    Console.WriteLine(item);
            //}
            //double x = 0.000000000000000000000001;
            //double y = 0.0000000003;
            //Console.WriteLine(x + y);

        }
        public static double ClcArea(IAerea area)
        {
           return area.Area();
        }
    }
}
