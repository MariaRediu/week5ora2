using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Shapes
{
   public class Rectangle:Shape
    {
        public Rectangle(int h,int w) : base(h, w)
        {

        }
        public override int CalculateSurface()
        {
            return height * width;
        }

    }
}
