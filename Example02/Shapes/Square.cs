using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Example02.Geometry
{
    public class Square : I2dObject
    {
        public decimal EdgeLength { get;}

        public Square(decimal edgeLength)
        {
            EdgeLength = edgeLength;
        }

        public decimal Circumference => 4 * EdgeLength;

        public decimal Area => EdgeLength * EdgeLength;
    }
}
