using Example02.Geometry;
using Example02.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoDObjects = new List<I2dObject>();
            twoDObjects.Add(new Square(4));
            twoDObjects.Add(new Circle(2));
            //twoDObjects.Add(new Triangle(3, 2));
            PrintArea(twoDObjects);
            Console.ReadLine();
        }

        static void PrintArea<T>(List<T> twoDObjects) where T : I2dObject
        {
            foreach (var twoDObject in twoDObjects)
            {
                Console.WriteLine($"Area: {twoDObject.Area}");
            }
        }
    }
}
