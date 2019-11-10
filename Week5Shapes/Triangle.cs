using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Shapes
{
    public class Triangle:Shape
    {
        public Triangle(int h, int w) : base(h, w)
        {

        }
        public override int CalculateSurface()
        {
            return this.height * this.width /2;
        }
    }
}
