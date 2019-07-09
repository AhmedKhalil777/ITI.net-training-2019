using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle car = new Vehicle();
            System.Console.WriteLine(car.ToString());
            car.pressHorn();
            //Access modifier private can't be access only on their class
            //car.MonitorOilTemperature();

           
            Rectangle rect2 = new Rectangle(5,10);
            System.Console.WriteLine(rect2.Area);
            
        }
    }

    class Vehicle
    {
       
      public void pressHorn(){
             System.Console.WriteLine("Horn Horn Horn !!!");

      }

      private void MonitorOilTemperature()
      { 
    // Internal oil temperature monitoring code...;
        Console.Write("This is so dangerous");
      }
    }
}
