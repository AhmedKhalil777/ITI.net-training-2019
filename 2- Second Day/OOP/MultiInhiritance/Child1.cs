using System;
using System.Collections.Generic;
using System.Text;

namespace MultiInhiritance
{
    class Child1 :Parent
    {
        protected int z;

        public Child1(int x , int y , int z):base(x,y,false)
        {
            this.z = z;
        }

        public override int Product()
        {
            return x * y * z;
        }

        public int GetZ()
        {
            return z;
        }
        public void SetZ(int z)
        {
            this.z = z;
        }


    }
}
