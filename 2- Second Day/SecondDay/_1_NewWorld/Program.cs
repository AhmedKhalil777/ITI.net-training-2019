using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_NewWorld
{

     public enum position
    {
        Admin = 0 , Tech = 1 , manager = 2

    }
    public enum JopTime
    {
        fulltime =0 , parttime = 1
    }
    public struct Employee
    {
       public int id;
       public string name;
        public float salary;
         public position Position;
         public JopTime JopTime;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            Console.WriteLine("Enter The Id :");
            employee.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Name:");
            employee.name = Console.ReadLine();
            Console.WriteLine("Enter The Salary :");
            employee.salary = float.Parse(Console.ReadLine());
            Console.WriteLine("choose The Position : \n 0 - Admin \n 1 - Tech \n 2 - manager ");
            int x = int.Parse(Console.ReadLine());
            employee.Position = (position)x;
            Console.WriteLine("choose The Joptime : \n 0 - full; \n 1- Part ");
             x = int.Parse(Console.ReadLine());
            employee.JopTime = (JopTime)x;


            Console.WriteLine("Employee {0} : {1} , {2} , {3} , {4}", employee.id, employee.name 
                , employee.salary,employee.Position , employee.JopTime);


           

            //Console.WriteLine("Enter The Num of Items :");
            //int num = int.Parse(Console.ReadLine());
            ////int[] x = new int[num];

            ////for (int i = 0; i < num; i++)
            ////{
            ////    Console.WriteLine("Enter The num {0}" , i+1);7
            ////    x[i] = int.Parse(Console.ReadLine());
            ////}

            //int min , max  , z  ;
            //Console.WriteLine("Enter The Num :");
            //z = int.Parse(Console.ReadLine());
            //max = min = z;

            //for (int i = 0  ; i < num-1; i++)
            //{
                
            //    Console.WriteLine("Enter The Num :");

            //    //if(min ==0 || max == 0)
            //    //{
            //    //    min = z;
            //    //    max = z; 
            //    //}
            //    z = int.Parse(Console.ReadLine());


            //    if (z>min )
            //    {
            //        max = z;
            //    }
                
            //    else if (z<max)
            //    {
            //        min = z;
            //    }
             
             

            //}
            //Console.WriteLine("The MAX =" + min);
            //Console.WriteLine("The Min =" + max );


        }
        static int Max( int[] x)
        {
            return x.Max();
        }

        static int Min(int[] x)
        {
            return x.Min();
        }
    }
}
