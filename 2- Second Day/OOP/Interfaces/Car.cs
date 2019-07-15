using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Car : IEqual<Car> , IProgress<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        
        public bool Equals(Car car)
        {
            return this.Make == car.Make &&
                   this.Model == car.Model &&
                   this.Year == car.Year;
        }
        public void Report(Car car)
        {
            Console.WriteLine("Me {0} : I reported :",this.Make+" : "+this.Model);
            Console.WriteLine("Make :" + car.Make);
            Console.WriteLine("Model : " + car.Model);
            Console.WriteLine("Year :" + car.Year);
        }
    }
}
