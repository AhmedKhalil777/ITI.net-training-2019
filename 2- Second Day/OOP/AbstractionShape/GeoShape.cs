using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionShape
{
    class GeoShape
    {

        public static float SumArea(params Shape[] shapes)
        {
            float sum = 0;
            foreach (var shape in shapes)
            {
                sum += shape.Area();
            }
            return sum;
        }

    }
}
