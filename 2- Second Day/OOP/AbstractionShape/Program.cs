using System;

namespace AbstractionShape
{
    class Program
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine("The Sum Area Of Shapes : {0}" ,
                GeoShape.SumArea(new Circle(4), new Triangle(4, 5), new Square(5), new Rectangle(3, 5))
                );
        }
    }
}
