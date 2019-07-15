using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    class Circle : Shape
    {
        public Circle(int r):base(r){}

        public override float Area()
        {
            return (float)Math.PI * D1 * D1;
        }
    }
}
