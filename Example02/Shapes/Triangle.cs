using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02.Shapes
{
    public class Triangle
    {
        public Triangle(decimal baseLength, decimal height)
        {
            BaseLength = baseLength;
            Height = height;
        }
        public decimal BaseLength { get; }
        public decimal Height { get;}

        public decimal Area => BaseLength * Height * 0.5m;
    }
}
