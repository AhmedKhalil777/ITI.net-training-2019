using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Make = "BMW", Model = "x43", Year = "2019" };
            Car car2 = new Car { Make = "Nissan", Model = "N52", Year = "2019" };
            Car car3 = new Car { Make = "BMW", Model = "x43", Year = "2019" };
            Console.WriteLine(car3.Equals(car2));
            Console.WriteLine(car3.Equals(car1));
            car1.Report(car2);

        }
    }
}
