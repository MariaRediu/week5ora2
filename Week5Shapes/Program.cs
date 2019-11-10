using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(2, 5);
            Rectangle d = new Rectangle(6, 3);
            Circle c = new Circle(4);
            // t.CalculateSurface();
            //d.CalculateSurface();
            //  c.CalculateSurface();

            List<Shape> shapes = new List<Shape>();
            shapes.Add(t);
            shapes.Add(d);
            shapes.Add(c);

            foreach (var element  in shapes)
            {
                Console.WriteLine(element.CalculateSurface());
            }
            Console.ReadLine();

        }
    }
}
