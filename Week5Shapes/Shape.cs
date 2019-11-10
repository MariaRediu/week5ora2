using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Shapes
{
    public abstract class Shape
    {
        protected int height;
        protected int width;

        public Shape(int h,int w)
        {
            this.height = h;
            this.width = w;
        }

        public abstract int CalculateSurface();

    }
}
