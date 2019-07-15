using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    class Square : Rectangle
    {
        public Square(int Width):base(Width,Width){}

        public override float Area()
        {
            return base.Area();
        }
    }
}
