using System;
using System.Collections.Generic;
using System.Text;

namespace MultiInhiritance
{
    class Child2 :Child1
    {
        int a;
        public Child2(int x , int y , int z , int a):base(x,y,z)
        {
            this.a = a;
        }
        public override int Product()
        {
            return x * y * z * a;
        }
        public int GetA()
        {
            return a;
        }
        public void SetA(int a)
        {
            this.a = a;
        }
    }
}
