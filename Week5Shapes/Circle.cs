using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Shapes
{
    public class Circle:Shape
    {
        public Circle (int l):base(l ,l)
        {

        }
        public override int CalculateSurface()
        {
            return this.height * this.width;
        }

    }
}
