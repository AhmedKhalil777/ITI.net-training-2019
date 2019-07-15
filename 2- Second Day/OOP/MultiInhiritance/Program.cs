using System;

namespace MultiInhiritance
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Child2 ch2_1 = new Child2(2, 2, 2, 2);
            Console.WriteLine(ch2_1.Product());
            
            Child1 ch1_1 = ch2_1;
            Console.WriteLine(ch1_1.Product());

            Parent p1 = ch1_1;
            Console.WriteLine(p1.Product());
            /////////////////////////////////////////////////
            Child1 ch2_2 = new Child1(2, 2, 2);
            Console.WriteLine(ch2_2.Product());
            Parent p2 = ch2_2;
            Console.WriteLine(p2.Product());
            /////////////////////////////////////////////////
            Parent p3 = new Parent(2, 2,false);
            Console.WriteLine(p3.Product());
            GC.Collect();

            dynamic s1 = p1;
            Console.WriteLine(s1.Product());
            s1 = p2;
            Console.WriteLine(s1.Product());
            s1 = p3;
            Console.WriteLine(s1.Product());

        }
    }
}
