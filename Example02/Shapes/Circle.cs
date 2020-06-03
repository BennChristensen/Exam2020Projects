using Example02.Geometry;
using Example02.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Circle : TwoDShape, I2dObject
    {
        public decimal Radius { get; }

        public decimal Circumference => 2 * (decimal)Math.PI * Radius;

        public decimal Area => (decimal)Math.PI * Radius * Radius;

        public Circle(decimal radius)
        {
            Radius = radius;
        }
    }
}
