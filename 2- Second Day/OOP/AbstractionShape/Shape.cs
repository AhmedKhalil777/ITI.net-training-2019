using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    abstract class Shape
    {
        public Shape(int Homo)
        {
            D1 = D2 = Homo;
        }
        public Shape(int D1 , int D2)
        {
            this.D1 = D1;
            this.D2 = D2;
        }
        public int D1 { get; set; }
        public int D2 { get; set; }

        public abstract float Area();
    }
}
