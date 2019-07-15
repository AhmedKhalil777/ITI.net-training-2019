using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    class Triangle : Shape
    {
        public Triangle(int Base , int Height):base(Base,Height){}

        public override float Area()
        {
            return (float)(0.5 * D1 * D2);
        }

    }
}
