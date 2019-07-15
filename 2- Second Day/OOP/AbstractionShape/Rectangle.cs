using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    class Rectangle : Shape
    {
        public Rectangle(int Width , int Height):base(Width,Height){}

        public override float Area()
        {
            return D1 * D2;
        }
    }
}
